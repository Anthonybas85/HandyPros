using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SSO.Form.Common;
namespace SSO.Form.Models
{
    public class ResetForm : CModel
    {

        private int UserID { get; set; }
        private DateTime RequestDate { get; set; }

        [LocalizedDisplayname("Password")]
        [Required("Password", "Required")]
        [MinLength(6, ErrorMessageResourceType = typeof(Resources.Site), ErrorMessageResourceName = "PasswordLength")]
        [MaxLength(16, ErrorMessageResourceType = typeof(Resources.Site), ErrorMessageResourceName = "PasswordLength")]
        [DataType(DataType.Password)]
        [RegularExpression(@"(\S)+", ErrorMessageResourceType = typeof(Resources.Site), ErrorMessageResourceName = "WhiteSpaceNotAllow")]
        public string Password { get; set; }

        [LocalizedDisplayname("ConfirmPassword")]
        [Required("ConfirmPassword", "Required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string QueryString { get; set; }

      

        public void read()
        {
            string[] tempA = this.QueryString.Split(';');
            this.UserID = Convert.ToInt32(tempA[0]);
            this.RequestDate = Convert.ToDateTime(tempA[1]);
            int BrokerHouseID = Convert.ToInt32(tempA[2]);

            CSessionUser sessionUser = new CSessionUser(BrokerHouseID);
           HttpContext.Current.Session["SessionUser"] = sessionUser;
        }

        public bool isTokenExpired()
        {
            TimeSpan ts = DateTime.Now.Subtract(this.RequestDate);
            double hours = ts.TotalHours;
            if (hours <= 10)
                return false;
            else
                return true;
        }
        public string resetPassword()
        {
            Business.Services.BDServices.UserService _uSrv = new Business.Services.BDServices.UserService();
            return _uSrv.ResetPassword(this.UserID, Comm.Text.Crypto.CalculateMD5Hash(this.Password));
        }
        public bool isValided()
        {
            // numbers
            bool meetRequirement = false;
            foreach (char c in this.Password.ToArray())
            {
                if (char.IsDigit(c))
                    meetRequirement = true;
            }
            if (!meetRequirement)
                return false;

            // Upcase
            meetRequirement = false;
            foreach (char c in this.Password.ToArray())
            {
                if (char.IsUpper(c))
                    meetRequirement = true;
            }
            if (!meetRequirement)
                return false;

            meetRequirement = false;
            foreach (char c in this.Password.ToArray())
            {
                if (char.IsLower(c))
                    meetRequirement = true;
            }
            if (!meetRequirement)
                return false;

            return true;
        }
    }
}