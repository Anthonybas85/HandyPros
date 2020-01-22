using System;
using System.Collections.Generic;

namespace Business.Comm
{
    public class MainConfig
    {

        #region Broker Portal
        public static class BrokerPortal
        {
            public static class Settings
            {
                public static string Default_Language = "en-ca";
                public static List<string> Supported_Languages = getListSettings("Supported_Languages");
                public static List<string> Supported_DropDown_Languages = getListSettings("Supported_DropDown_Languages");
                public static int ApplicationId = getIntSettings("BrokerPortalApplicationId");//10028;
                public static string TicketingTool_URL = getStringSettings("TicketingTool_URL"); //http://192.168.29.5:4004/
            }
        }
        #endregion

        #region Radius Portal
        public static class RadiusPortal
        {
            public static class Settings
            {
                public static string Default_Language = "en-ca";
                public static List<string> Supported_Languages = getListSettings("Supported_Languages");
                public static List<string> Supported_DropDown_Languages = getListSettings("Supported_DropDown_Languages");
                public static int ApplicationId = getIntSettings("RadiusPortalApplicationId");//10052;
                                                                                              // public static string TicketingTool_URL = getStringSettings("TicketingTool_URL"); //http://192.168.29.5:4004/
            }
        }
        #endregion

        #region Broker Portal Admin
        public static class BrokerPortalAdmin
        {
            public static class Settings
            {
                public static int ApplicationId = getIntSettings("BrokerPortalAdminApplicationId");//10030;
                public static int NewsCategoryID = getIntSettings("NewsCategoryID");//1;
                public static int DocumentsCategoryID = getIntSettings("DocumentsCategoryID");//2;
                public static int LendersCategoryID = getIntSettings("LendersCategoryID");//3;
                public static int PartnersCategoryID = getIntSettings("PartnersCategoryID");//53;
                public static int MaServicesCategoryID = getIntSettings("MaServicesCategoryID");//56;
                public static int FAQCategoryID = getIntSettings("FAQCategoryID");//9;
                public static int MarketingTemplatesCategoryID = getIntSettings("MarketingTemplatesCategoryID");//233;
                public static int EmailTemplatesCategoryID = getIntSettings("EmailTemplatesCategoryID");//364;

            }
        }
        #endregion

        #region FileManager

        public static class FileManager
        {
            public static string ROOT_URL = getStringSettings("ROOT_URL");
            public static string ROOT_FOLDER = getStringSettings("ROOT_FOLDER");

            public static string BROKER_PROFILE = getStringSettings("BROKER_PROFILE");
            public static string BROKER_DIRECTORY = getStringSettings("BROKER_DIRECTORY");
            public static string BROKER_PORTAL_CMS = getStringSettings("BROKER_PORTAL_CMS");
            public static string TEMPORARY_STORAGE = getStringSettings("TEMPORARY_STORAGE");
            public static string BrokerDirectoryDocuments = getStringSettings("BrokerDirectoryDocuments");
            public static string EMAIL_BROADCAST = getStringSettings("EMAIL_BROADCAST");
        }
        #endregion

        public static class SSO
        {
            public static string SSO_URL = getStringSettings("SSO_Form_URL");
            public static string SSO_WIN_URL = getStringSettings("SSO_Win_URL");
            public static string SSO_MYACCOUNT_URL = getStringSettings("MY_Account_URL");//"#";
            public static int BROKERDIRECTORY_APPLICATION_ID = getIntSettings("BrokerDirectoryApplicationId");//10026;
        }

        public static class BrokerDirectory
        {
            public static int BROKERHOUSE_MA_ID = getIntSettings("BROKERHOUSE_MA_ID");
            public static int BROKERHOUSE_RADIUS_ID = getIntSettings("BROKERHOUSE_RADIUS_ID");
            public static int BROKER_DIRECTORY_SYSTEM_USER_ID = getIntSettings("DEFAULT_LOOKUP_USER_ID");
            public static string USER_DEFAULT_PASSWORD = getStringSettings("USER_DEFAULT_PASSWORD");
            public static int BROKER_USERGROUP_ID = getIntSettings("BROKER_USERGROUP_ID");
            public static int BROKER_STATUS_ID_ACTIVE = getIntSettings("BROKER_STATUS_ID_ACTIVE");
            public static int BROKER_STATUS_ID_INACTIVE = getIntSettings("BROKER_STATUS_ID_INACTIVE");
            public static int BROKER_STATUS_ID_PENDING = getIntSettings("BROKER_STATUS_ID_PENDING");
            public static int DEFAULT_LOOKUP_USER_ID = getIntSettings("DEFAULT_LOOKUP_USER_ID");

            public static int RADIUS_STATUS_ID_APPROVED = getIntSettings("RADIUS_STATUS_ID_APPROVED");
            public static int RADIUS_STATUS_ID_APPROVED_MAPLE = getIntSettings("RADIUS_STATUS_ID_APPROVED_MAPLE");
            public static int RADIUS_STATUS_ID_NOTAPPROVED = getIntSettings("RADIUS_STATUS_ID_NOTAPPROVED");
            public static int RADIUS_STATUS_ID_TERMINATED = getIntSettings("RADIUS_STATUS_ID_TERMINATED");

            #region User role type code
            public static int USERROLETYPE_SUPERUSER = getIntSettings("USERROLETYPE_SUPERUSER");
            public static int USERROLETYPE_ITSUPERUSER = getIntSettings("USERROLETYPE_ITSUPERUSER");
            public static int USERROLETYPE_RECORDSADMINRO = getIntSettings("USERROLETYPE_RECORDSADMINRO");
            public static int USERROLETYPE_RECORDSADMINRW = getIntSettings("USERROLETYPE_RECORDSADMINRW");
            public static int USERROLETYPE_RECORDSADMINLIMITED = getIntSettings("USERROLETYPE_RECORDSADMINLIMITED");
            #endregion


            #region User role type code
            public static int USERGROUP_RADIUSBROKER = getIntSettings("USERGROUP_RADIUSBROKER");

            #endregion

            public static int LU_ADDRESS_TYPE_HOME = getIntSettings("LU_ADDRESS_TYPE_HOME");
            public static int LU_ADDRESS_TYPE_BUSINESS = getIntSettings("LU_ADDRESS_TYPE_BUSINESS");
            public static int LU_ADDRESS_TYPE_MAILING = getIntSettings("LU_ADDRESS_TYPE_MAILING");
            public static int LU_ADDRESS_TYPE_T4 = getIntSettings("LU_ADDRESS_TYPE_T4");

            public static int LU_CONTACT_METHOD_HOME_PHONE = getIntSettings("LU_CONTACT_METHOD_HOME_PHONE");
            public static int LU_CONTACT_METHOD_EMERGENCY_CONTACT = getIntSettings("LU_CONTACT_METHOD_EMERGENCY_CONTACT");
            public static int LU_CONTACT_METHOD_EMAIL = getIntSettings("LU_CONTACT_METHOD_EMAIL");
            public static int LU_CONTACT_METHOD_PERSONAL_EMAIL = getIntSettings("LU_CONTACT_METHOD_PERSONAL_EMAIL");
            public static int LU_CONTACT_METHOD_CELL = getIntSettings("LU_CONTACT_METHOD_CELL");
            public static int LU_CONTACT_METHOD_FAX = getIntSettings("LU_CONTACT_METHOD_FAX");
            public static int LU_CONTACT_METHOD_BIZ_EXT = getIntSettings("LU_CONTACT_METHOD_BIZ_EXT");
            public static int LU_CONTACT_METHOD_BIZ = getIntSettings("LU_CONTACT_METHOD_BIZ");
            public static int LU_PROFILE_TYPE_WEB = getIntSettings("LU_PROFILE_TYPE_WEB");
            public static int LU_PROFILE_TYPE_EXIMIUS = getIntSettings("LU_PROFILE_TYPE_EXIMIUS");
            public static int LU_PROFILE_TYPE_bUSINESSCARD = getIntSettings("LU_PROFILE_TYPE_bUSINESSCARD");
            public static int LU_PROFILE_TYPE_FEATURESHEET = getIntSettings("LU_PROFILE_TYPE_FEATURESHEET");
            public static int LU_PROFILE_TYPE_MARKETING = getIntSettings("LU_PROFILE_TYPE_MARKETING");
            public static int LU_PROFILE_TYPE_MARKETING_TEMPLATES = getIntSettings("LU_PROFILE_TYPE_MARKETING_TEMPLATES");

            public static int APPLICATION_FUNCTIONS_NEWS = getIntSettings("APPLICATION_FUNCTIONS_NEWS");
            public static int APPLICATION_FUNCTIONS_DOCUMENTS = getIntSettings("APPLICATION_FUNCTIONS_DOCUMENTS");
            public static int APPLICATION_FUNCTIONS_LENDERS = getIntSettings("APPLICATION_FUNCTIONS_LENDERS");
            public static int APPLICATION_FUNCTIONS_COMMISSIONS = getIntSettings("APPLICATION_FUNCTIONS_COMMISSIONS");
            public static int APPLICATION_FUNCTIONS_LOGINAS = getIntSettings("APPLICATION_FUNCTIONS_LOGINAS");

        }

        public static class Settings
        {
            public static int DB_SERVER_TIMEZONE_ID = getIntSettings("DB_SERVER_TIMEZONE_ID");
            public static string SMTP_SERVER = getStringSettings("SMTP_SERVER");
            public static string DEFAULT_FROM_ADDRESS = getStringSettings("DEFAULT_FROM_ADDRESS");
            public static string SUPPORT_EMAIL_ADDRESS = getStringSettings("SUPPORT_EMAIL_ADDRESS");
            public static int DEFAULT_SYSTEM_USER_ID = getIntSettings("DEFAULT_LOOKUP_USER_ID");
            public static int APPLICATION_ID_BROKER_DIRECTORY = getIntSettings("BrokerDirectoryApplicationId");
            public static int APPLICATION_ID_BROKER_PORTAL = getIntSettings("BrokerPortalApplicationId");
            public static int APPLICATION_ID_BROKER_PORATLADMIN = getIntSettings("BrokerPortalAdminApplicationId");
            public static int APPLICATION_ID_RADIUS_PORTAL = getIntSettings("RadiusPortalApplicationId");
            public static int APPLICATION_ID_RADIUS_FUNDING_TOOLS = getIntSettings("RadiusFundingToolsApplicationId");
            public static int APPLICATION_ID_COMPLIANCE = getIntSettings("ComplianceApplicationId");
            public static int APPLICATION_ID_COMPLIANCE_ADMIN = getIntSettings("ComplianceAdminApplicationId");
            public static int APPLICATION_ID_COMMISSION = getIntSettings("CommissionApplicationId");
            public static int APPLICATION_ID_COMMISSION_ADMIN = getIntSettings("CommissionAdminApplicationId");
            public static int APPLICATION_ID_MARKETINGMATERIA = getIntSettings("MarketingMaterialApplicationId");
            public static int APPLICATION_ID_EXIMIUS = getIntSettings("EximiusApplicationId");
            public static int APPLICATION_ID_CALCULATOR = getIntSettings("CalculatorApplicationId");
            public static string WEBSITEBUILDER_2_URL = getStringSettings("WEBSITEBUILDER_2_URL");

        }

        public static class BrokerProfile
        {
            public static int PROFILE_FIELD_TYPE_TEXTBOX = getIntSettings("PROFILE_FIELD_TYPE_TEXTBOX");
            public static int PROFILE_FIELD_TYPE_IMAGE = getIntSettings("PROFILE_FIELD_TYPE_IMAGE");
            public static int PROFILE_FIELD_TYPE_CHECKBOX = getIntSettings("PROFILE_FIELD_TYPE_CHECKBOX");
            public static int PROFILE_FIELD_TYPE_COMBOBOX = getIntSettings("PROFILE_FIELD_TYPE_COMBOBOX");
            public static int PROFILE_FIELD_TYPE_LIST = getIntSettings("PROFILE_FIELD_TYPE_LIST");
            public static int PROFILE_FIELD_TYPE_MULTILINE = getIntSettings("PROFILE_FIELD_TYPE_MULTILINE");
            public static int PROFILE_FIELD_TYPE_RICH_EDITOR = getIntSettings("PROFILE_FIELD_TYPE_RICH_EDITOR");
        }


        #region Tools
        public static int getIntSettings(string key)
        {
            int value = 0;
            try
            {
                value = int.Parse(System.Configuration.ConfigurationManager.AppSettings[key]);
            }
            catch (Exception) { }
            return value;
        }

        public static string getStringSettings(string key)
        {
            string value = string.Empty;
            try
            {
                value = System.Configuration.ConfigurationManager.AppSettings[key];
            }
            catch (Exception) { }
            return value;
        }

        public static List<string> getListSettings(string key)
        {
            List<string> values = new List<string>();
            try
            {
                string value = System.Configuration.ConfigurationManager.AppSettings[key];
                var tempList = value.Split(',');
                foreach (string tempString in tempList)
                {
                    if (tempString.Trim() != "")
                        values.Add(tempString);
                }
            }
            catch (Exception) { }
            return values;
        }
        #endregion
    }
}
