using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Comm;
using DataModel.Models;

namespace Business.Services
{
    public class LoginService : CService
    {
        //public int GetUserIdByDomianUsername(out string errorCode, string domain, string userName)
        //{
        //    errorCode = string.Empty;
        //    try
        //    {
        //        var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
        //        var user = brokerDirectoryNewEntities.Users.SingleOrDefault(p => p.DomainName == domain && p.LoginName == userName);

        //        if (user == null)
        //        {
        //            errorCode = Comm.errorCode.LOGIN_SVC_ERR_UNKNOW_USERNAME;
        //            return 0;
        //        }
        //        if (user.ActiveInd != 1)
        //        {
        //            errorCode = Comm.errorCode.LOGIN_SVC_ERR_INACTIVE_USER;
        //            return 0;
        //        }

        //        return user.UserID;
        //    }
        //    catch (Exception)
        //    {
        //        errorCode = Comm.errorCode.UNKNOW_ERROR;
        //        return 0;
        //    }
        //}

        //public int GetUserIDByLogIn(out string errorCode, string userName, string password)
        //{
        //    errorCode = string.Empty;
        //    try
        //    {
        //        var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
        //        var user = brokerDirectoryNewEntities.Users.SingleOrDefault(p => p.LoginName == userName);

        //        if (user == null)
        //        {
        //            errorCode = Comm.errorCode.LOGIN_SVC_ERR_UNKNOW_USERNAME;
        //            return 0;
        //        }
        //        else
        //        {
        //            string hashedPWD = Comm.CCryptography.CalculateMD5Hash(password);
        //            if (user.Password != hashedPWD)
        //            {
        //                errorCode = Comm.errorCode.LOGIN_SVC_ERR_UNKNOW_USERNAME; // LOGIN_SVC_ERR_WRONG_PASSWORD;
        //                return 0;
        //            }

        //            if (user.ActiveInd != 1)
        //            {
        //                errorCode = Comm.errorCode.LOGIN_SVC_ERR_INACTIVE_USER;
        //                return 0;
        //            }
        //        }
        //        return user.UserID;
        //    }
        //    catch (Exception)
        //    {
        //        errorCode = Comm.errorCode.UNKNOW_ERROR;
        //        return 0;
        //    }
        //}

        public string CreateToken(out string errorCode, int appId, int loginAsUserId, string returnURL, int currentUserId = 0)
        {
            //    var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();

            errorCode = string.Empty;

            //    var sql = @"select 1 from [user] u left join broker b 
            //  on u.brokerid=b.brokerid
            //  where u.userid=" + loginAsUserId + " and b.brokerstatusid=" + MainConfig.BrokerDirectory.BROKER_STATUS_ID_ACTIVE.ToString();

            //    var effectRows = brokerDirectoryNewEntities.ExecuteStoreQuery<int>(sql).Count();
            //    if (effectRows == 0)
            //    {
            //        errorCode = Comm.errorCode.LOGIN_SVC_ERR_APPLICATION_NO_PERMISSION;
            //        return string.Empty;
            //    }

            //    // Check if user have permission to open application
            //    sql = @"SELECT  1 FROM  UserGroup_Xref AS ugx LEFT OUTER JOIN
            //                 UserGroupApplication_Xref AS ugax ON ugx.UserGroupID = ugax.UserGroupID
            //                WHERE (ugx.UserID = " + loginAsUserId.ToString() + " ) AND (ugax.ApplicationID = " + appId.ToString() + ")";

            //    effectRows = brokerDirectoryNewEntities.ExecuteStoreQuery<int>(sql).Count();
            //    if (effectRows == 0)
            //    {
            //        // check userapplication table
            //        sql = @"select * from userapplication where userid=" + loginAsUserId.ToString() + " and applicationid=" + appId.ToString();
            //        effectRows = brokerDirectoryNewEntities.ExecuteStoreQuery<int>(sql).Count();
            //        if (effectRows == 0)
            //        {
            //            errorCode = Comm.errorCode.LOGIN_SVC_ERR_APPLICATION_NO_PERMISSION;
            //            return string.Empty;
            //        }
            //    }
            //    /*
            //if (effectRows == 0) {
            //  errorCode = Comm.errorCode.LOGIN_SVC_ERR_APPLICATION_NO_PERMISSION;
            //  return string.Empty;
            //}
            // */

            //    string token = Guid.NewGuid().ToString();
            //    // create token   
            //    brokerDirectoryNewEntities.UserTokens.AddObject(new UserToken()
            //    {
            //        Token = token,
            //        UserID = loginAsUserId,
            //        ApplicationID = appId,
            //        CreatedTime = GetServerDateTime(),
            //        CreatedBy = currentUserId
            //    });
            //    brokerDirectoryNewEntities.SaveChanges();

            //    var app = brokerDirectoryNewEntities.Applications.SingleOrDefault(p => p.ApplicationID == appId);
            //    if (app != null)
            //    {
            //        var url = app.URLAppLogin + "?token=" + token + "&LoginAsFlag=1" + "&returnURL=" + returnURL;
            //        return url;
            //    }
            //  return null;
            return errorCode;
        }

        public UserDetailsModel GetUserSessionDetails(out string errorCode, int userId, int appId)
        {
            errorCode = string.Empty;
            try
            {
                var userDetailsModel = new UserDetailsModel();

                //var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
                //var m = brokerDirectoryNewEntities.Users.SingleOrDefault(p => p.UserID == userId);
                //if (m != null)
                //{
                //    userDetailsModel.LoginName = !string.IsNullOrEmpty(m.LoginName) ? m.LoginName : string.Empty;
                //    userDetailsModel.Email = !string.IsNullOrEmpty(m.Email) ? m.Email : string.Empty;
                //    userDetailsModel.FirstName = !string.IsNullOrEmpty(m.FirstName) ? m.FirstName : string.Empty;
                //    userDetailsModel.LastName = !string.IsNullOrEmpty(m.LastName) ? m.LastName : string.Empty;
                //    userDetailsModel.BuildUserNavBar = !string.IsNullOrEmpty(BuildUserNavBar(userId, appId)) ? BuildUserNavBar(userId, appId) : string.Empty;
                //    userDetailsModel.BrokerID = (m.BrokerID != null && m.BrokerID != 0) ? m.BrokerID : null;
                //    userDetailsModel.TimeZoneID = (m.TimeZoneID != null && m.TimeZoneID != 0) ? m.TimeZoneID : null;
                //    userDetailsModel.UserID = m.UserID != 0 ? m.UserID : 0;
                //    userDetailsModel.UserTypeCode = (m.UserTypeCode != null && m.UserTypeCode != 0) ? m.UserTypeCode : null;
                //}
                return userDetailsModel;
            }
            catch (Exception)
            {
                errorCode = Comm.errorCode.UNKNOW_ERROR;
                return null;
            }
        }

        private string GetSafeJS(string str)
        {
            return str.Replace("'", "\\'");
        }

        public string BuildUserNavBar(int userId, int appId)
        {
            var sb = new StringBuilder();

            //string cssURL = MainConfig.SSO.SSO_URL;
            const string cssURL = "https://sso.malink.ca:8110";
            string myAccountURL = MainConfig.SSO.SSO_MYACCOUNT_URL;


            string query = @"select distinct uga_x.applicationid from usergroup_xref ug left join  usergroupapplication_xref uga_x on ug.usergroupid=uga_x.usergroupid
                          where ug.userid=" + userId;

            //var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
            //List<int> applicationList = brokerDirectoryNewEntities.ExecuteStoreQuery<int>(query).ToList();

            //var curApp = brokerDirectoryNewEntities.Applications.SingleOrDefault(p => p.ApplicationID == appId);
            //var user = brokerDirectoryNewEntities.Users.SingleOrDefault(p => p.UserID == userId);

            //sb.Append(@"<link href=""" + cssURL + @"/resource/public/css/MX_STYLE.css"" rel=Stylesheet type=""text/css"" />");
            //sb.Append(@"<link href='/Content/css/Site.css' rel='Stylesheet' type='text/css' />");
            //sb.Append(@"<link href=""" + cssURL + @"/resource/public/js/mx_table/themes/smoothness/jquery-ui-1.8.4.custom.css"" rel=Stylesheet type=""text/css"" />");
            //sb.Append(@"<link href=""" + cssURL + @"/resource/public/js/mx_datepicker/jquery.datepick.css"" rel=Stylesheet type=""text/css"" />");

            //sb.Append(@"<script type=""text/javascript"">");
            //if (user != null)
            //    sb.Append("var _mx_full_name='" + (GetSafeJS(user.FirstName.Trim()) + " " + GetSafeJS(user.LastName.Trim())).Replace(" ", "&nbsp;") + "';");
            //if (curApp != null) sb.Append("var _mx_logout_url = '" + curApp.URLLogout + "';");
            //sb.Append("var _mx_my_account_url = '" + myAccountURL + "';");

            //int applicationCount = applicationList.Count();
            //sb.Append("var _mx_applications=[" + (applicationCount - 1) + "];");

            //var app = brokerDirectoryNewEntities.Applications.SingleOrDefault(p => p.ApplicationID == appId);
            //if (app != null)
            //{
            //    string currentAppLauncherUrl = app.URLAppLauncher;


            //    var navBarList = new System.Collections.ArrayList();
            //    if (appId != 10052)
            //    {
            //        navBarList.Add(10026);
            //        navBarList.Add(10028);
            //        navBarList.Add(10030);
            //    }
            //    else
            //    {
            //        navBarList.Add(10052);
            //    }

            //    int iIndex = 0;
            //    for (int i = 0; i < applicationCount; i++)
            //    {
            //        var currentApplicationID = applicationList[i];
            //        if (currentApplicationID == appId)
            //            continue;

            //        if (!navBarList.Contains(currentApplicationID))
            //            continue;

            //        app = brokerDirectoryNewEntities.Applications.SingleOrDefault(p => p.ApplicationID == currentApplicationID);
            //        sb.Append("_mx_applications[" + iIndex + "]=[2];");
            //        if (app != null)
            //        {
            //            sb.Append("_mx_applications[" + iIndex + "][0]='" + app.Name.Replace("'", "\\'") + "';");
            //            sb.Append("_mx_applications[" + iIndex + "][1]='" + currentAppLauncherUrl + "?appId=" + app.ApplicationID + "';");
            //        }
            //        iIndex++;
            //    }
            //}
            //sb.Append("</script>");

            return System.Net.WebUtility.HtmlEncode(sb.ToString());
        }

        public int GetUserIdFromToken(string token, int appId)
        {
            //    try
            //    {
            //        var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
            //        const string query = "delete from usertoken where datediff(n,createdtime,getdate()) > 2";
            //        brokerDirectoryNewEntities.ExecuteStoreCommand(query);
            //        brokerDirectoryNewEntities.SaveChanges();

            //        var m = brokerDirectoryNewEntities.UserTokens.SingleOrDefault(p => p.ApplicationID == appId && p.Token == token);

            //        if (m != null && m.TokenID != 0)
            //        {
            //            int userId = Convert.ToInt32(m.UserID);
            //            brokerDirectoryNewEntities.UserTokens.DeleteObject(m);
            //            brokerDirectoryNewEntities.SaveChanges();
            //            return userId;
            //        }
            //        return 0;
            //    }
            //    catch (Exception)
            //    {
            //        return 0;
            //    }
            return 0;
        }

        public int GetUserIdFromToken(string token, int appId, out int appLauncherId)
        {
            appLauncherId = 0;
            //    try
            //    {
            //        var brokerDirectoryNewEntities = new BrokerDirectoryNewEntities();
            //        const string query = "delete from usertoken where datediff(n,createdtime,getdate()) > 2";
            //        brokerDirectoryNewEntities.ExecuteStoreCommand(query);
            //        brokerDirectoryNewEntities.SaveChanges();

            //        var m = brokerDirectoryNewEntities.UserTokens.SingleOrDefault(p => p.ApplicationID == appId && p.Token == token);

            //        if (m != null && m.TokenID != 0)
            //        {
            //            int userId = Convert.ToInt32(m.UserID);
            //            int createdBy = Convert.ToInt32(m.CreatedBy);
            //            appLauncherId = (createdBy == 0 ? userId : createdBy);
            //            brokerDirectoryNewEntities.UserTokens.DeleteObject(m);
            //            brokerDirectoryNewEntities.SaveChanges();
            //            return userId;
            //        }
            //        return 0;
            //    }
            //    catch (Exception)
            //    {
            //        return 0;
            //    }
            return appLauncherId;
        }
    }
}
