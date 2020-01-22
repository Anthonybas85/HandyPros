using Business.Comm;
using Business.Services;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HandyProsServiceReports.Controllers
{
    public class AuthController : CController
    {
        public AuthController()
        {
        }

        public ActionResult Index()
        {
            return RedirectToAction("HandyProsIndex", "Home");
            string URLFormLogin = MainConfig.SSO.SSO_URL;
            string returnURL = "";
            if (this.Request.QueryString["returnURL"] != null)
            {
                returnURL = this.Request.QueryString["returnURL"].ToString();
            }
            returnURL = HttpUtility.UrlEncode(returnURL);
            URLFormLogin += "?returnURL=" + returnURL;
            URLFormLogin += "&appId=" + GlobalVars.ApplicationId;
            return Redirect(URLFormLogin);
        }

        public ActionResult AppLogon()
        {
            int userId = 0, appLauncherId = 0;
            string returnURL = "/";

            try
            {
                FormsAuthentication.SignOut();
                this.Session.Clear();
            }
            catch (Exception) { }

            if (this.Request.QueryString["local"] != null)
            {
                //userId = 3044;
                //userId = 1844;
                //userId = 3060;
                userId = 5325; //Anthony Bou Absy
                //userId = 4673;  // Jamil Mourad
                //userId = 5064; //David Hnatiuk
            }
            else
            {
                string token = string.Empty;
                if (this.Request.QueryString["token"] != null)
                    token = this.Request.QueryString["token"].ToString();
                if (token == string.Empty)
                    return Redirect("/");

                if (this.Request.QueryString["returnURL"] != null)
                    returnURL = this.Request.QueryString["returnURL"].ToString();
                if (returnURL.Trim() == "")
                    returnURL = "/";

                LoginService svc = new LoginService();
                userId = svc.GetUserIdFromToken(token, GlobalVars.ApplicationId, out appLauncherId);
            }

            if (string.IsNullOrEmpty(userId.ToString()) || userId == 0)
                return Redirect("/");
            FormsAuthentication.SetAuthCookie(userId.ToString(), false);
            this.Session[FormsAuthentication.FormsCookieName] = userId;

            CAuth auth = new CAuth();
            auth.LoginUser(appLauncherId);
            return Redirect(returnURL);
        }

        public ActionResult AppLogout()
        {
            FormsAuthentication.SignOut();

            return Redirect("/");
        }

        public ActionResult AppLauncher(int appId)
        {

           LoginService svc = new LoginService();
            string errorCode = string.Empty;
            string URL = svc.CreateToken(out errorCode, appId, GlobalVars.LoggedInUser.UserId, "/");
            return Redirect(URL);
        }

        public ActionResult Error()
        {
            if (errorCode == Business.Comm.errorCode.NO_PERMISSION)
            {
                return Redirect("/Auth/NoPermission");
            }
            else
            {
                return View();
            }
        }

        public ActionResult NoPermission()
        {
            return View();
        }
    }
}
