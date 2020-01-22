using System.Web;
using System.Web.Security;
using DataModel.Models;

namespace Business.Comm
{
    public class CAuth
    {
        public CAuth() { }
        public void LoginUser(int appLauncherId = 0)
        {
            if (HttpContext.Current.Session["xm_user"] != null)
            {
                var sessionObj = (LoggedInUser)HttpContext.Current.Session["xm_user"];
                if (sessionObj.BrokerId > 0)
                    return;
            }
            int userId = 0;
            try
            {
                userId = int.Parse(HttpContext.Current.Session[FormsAuthentication.FormsCookieName].ToString());
                if (userId <= 0)
                {
                    HttpContext.Current.Response.Redirect("/Auth/AppLogout");
                    return;
                }
            }
            catch (System.Exception)
            {
                HttpContext.Current.Response.Redirect("/Auth/AppLogout");
                return;
            }


            string errorCode;

            Services.LoginService loginSvc = new Services.LoginService();
            var userDetails = loginSvc.GetUserSessionDetails(out errorCode, userId, GlobalVars.ApplicationId);

            if (errorCode == string.Empty)
            {
                if (appLauncherId == 0)
                {
                    appLauncherId = userId;
                }

                if (userDetails != null)
                {
                    LoggedInUser userObj = new LoggedInUser()
                    {
                        UserId = (userDetails.UserID.HasValue && userDetails.UserID != 0) ? userDetails.UserID.Value : 0,
                        AppLauncherUserId = appLauncherId,
                        EmailAddress = !string.IsNullOrEmpty(userDetails.Email) ? userDetails.Email : string.Empty,
                        FirstName = !string.IsNullOrEmpty(userDetails.FirstName) ? userDetails.FirstName : string.Empty,
                        LastName = !string.IsNullOrEmpty(userDetails.LastName) ? userDetails.LastName : string.Empty,
                        NavHTML = HttpUtility.HtmlDecode(!string.IsNullOrEmpty(userDetails.BuildUserNavBar) ? userDetails.BuildUserNavBar : string.Empty),
                        BrokerId = userDetails.BrokerID ?? 0,
                        TimeZoneId = userDetails.TimeZoneID ?? 0,
                        LoginName = !string.IsNullOrEmpty(userDetails.LoginName) ? userDetails.LoginName : string.Empty,
                        UserTypeCode = userDetails.UserTypeCode ?? 0
                    };


                    if (userObj.BrokerId > 0)
                        HttpContext.Current.Session["xm_user"] = userObj;
                    else
                        HttpContext.Current.Response.Redirect("/Home/Error"); //("/Auth/Error");
                }
            }
        }
    }
}