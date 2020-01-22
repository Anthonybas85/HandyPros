using System;
using System.Collections.Generic;
using System.Web;
using DataModels.Resources;

namespace DataModel.Common
{
    public class CommonResource
    {
        public static string GetResource(string resourceKey)
        {
            try
            {
                var currentCultureInfo = new System.Globalization.CultureInfo(GetCurrentLanguage());
                var resourceString = Resources.Resources.ResourceManager.GetString(resourceKey, currentCultureInfo);
                if (string.IsNullOrEmpty(resourceString))
                    return resourceKey;
                else
                    return resourceString;
            }

            catch (Exception)
            {
                return resourceKey;
            }
        }

        public static string GetCurrentLanguage()
        {
            try
            {
                // Cookie
                if (HttpContext.Current.Request.Cookies["Language"] != null)
                {
                    var hc = HttpContext.Current.Request.Cookies["Language"];
                    if (hc.Value != null && IsSupportedLanguage(hc.Value.ToLower()))
                        return hc.Value.ToLower();
                }
                // default
                return "en-CA";
            }
            catch (Exception)
            {
                return "en-CA";
            }
        }

        public static bool IsSupportedLanguage(string lan)
        {
            var supportedLanguages = new List<string> { "en-ca", "fr-ca" };
            return supportedLanguages.Contains(lan);
        }
    }
}
