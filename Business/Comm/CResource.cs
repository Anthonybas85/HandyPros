using System;
using System.Collections.Generic;
using System.Web;
using DataModel.Resources;

namespace Business.Comm
{
    public class CResource
    {
        public static string getResource(string resourceKey)
        {
            try
            {
                string resourceString = Resources.ResourceManager.GetString(resourceKey);
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
            if (HttpContext.Current.Request.Cookies["Language"] != null)
            {
                HttpCookie hc = HttpContext.Current.Request.Cookies["Language"];
                if (hc.Value != null && IsSupportedLanguage(hc.Value))
                    return hc.Value.ToString().ToLower();
            }
            return "en-ca";
        }

        private static bool IsSupportedLanguage(string lan)
        {
            var list = GetSupportLanguages();
            foreach (var language in list)
            {
                if (language.Key.ToLower() == lan.ToLower())
                    return true;
            }
            return false;
        }

        private static List<KeyValuePair<string, string>> GetSupportLanguages()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("en-ca", "en"));
            list.Add(new KeyValuePair<string, string>("fr-ca", "fr"));
            return list;
        }
    }
}