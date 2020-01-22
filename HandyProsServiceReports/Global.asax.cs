using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HandyProsServiceReports
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "HandyProsIndex", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
              "Default2", // Route name
              "{controller}/{action}/{id}/{id2}", // URL with parameters
              new { controller = "Home", action = "HandyProsIndex", id = UrlParameter.Optional, id2 = UrlParameter.Optional } // Parameter defaults
          );

        }

        void Session_Start(object sender, EventArgs e)
        {
            string sessionId = Session.SessionID;
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            try
            {
                HttpContext context = HttpContext.Current;
                for (int i = 0; i < context.Request.QueryString.Count; i++)
                {
                    string Q = context.Request.QueryString[i].Trim();

                    if (SQLInjectionPrevention(Q))
                        context.Response.End();
                }
            }
            catch (Exception) { }


        }

        private bool SQLInjectionPrevention(string Q)
        {
            bool Prevention = false;

            List<string> CheatSheet = new List<string>();
            CheatSheet.Add("--");
            CheatSheet.Add("/*");
            CheatSheet.Add("*/");
            CheatSheet.Add(";");

            foreach (string CS in CheatSheet)
            {
                if (Q.IndexOf(CS) > 0)
                    Prevention = true;
            }

            return Prevention;
        }
    }
}
