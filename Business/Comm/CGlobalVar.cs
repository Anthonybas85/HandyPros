using System;
using System.Configuration;
using System.Web;
using DataModel.Models;

namespace Business.Comm
{
    public static class GlobalVars
    {
        public static LoggedInUser LoggedInUser
        {
            get
            {
                var o = HttpContext.Current.Session["xm_user"];
                if (o != null)
                {
                    return (LoggedInUser)o;
                }
                else
                {
                    global::Business.Comm.CAuth auth = new CAuth();
                    auth.LoginUser();

                    o = HttpContext.Current.Session["xm_user"];
                    if (o != null)
                        return (LoggedInUser)o;
                }
                return null;
            }
        }

        public static staticKeys keys
        {
            get
            {
                return new staticKeys();
            }
        }

        public static int ApplicationId
        {
            get
            {
                return MainConfig.SSO.BROKERDIRECTORY_APPLICATION_ID;
            }
        }

        public static string SMTPServer
        {
            get
            {
                var o = ConfigurationManager.AppSettings["SMTP:Server"];
                if (o != null)
                    return o.ToString();
                return string.Empty;
            }
        }
    }

    [Serializable()]
    public class staticKeys
    {
        public staticKeys() { }
        //public int Country_CAN
        //{
        //    get
        //    {
        //        return CLookup.getLookupItemIdByValue("lkp_Country", "Canada");
        //    }
        //}

        //public int Address_Home
        //{
        //    get
        //    {
        //        return CLookup.getLookupItemIdByValue("lkp_AddressType", "Home Address");
        //    }
        //}

        //public int Address_Office
        //{
        //    get
        //    {
        //        return CLookup.getLookupItemIdByValue("lkp_AddressType", "Office Address");
        //    }
        //}

        //public int Address_Mailing
        //{
        //    get
        //    {
        //        return CLookup.getLookupItemIdByValue("lkp_AddressType", "Mailing Address");
        //    }
        //}

        //public int Address_T4A
        //{
        //    get
        //    {
        //        return CLookup.getLookupItemIdByValue("lkp_AddressType", "T4Address");
        //    }
        //}
    }
}