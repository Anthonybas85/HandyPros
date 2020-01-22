using System;

namespace Business.Comm
{
    public class CSessionUser
    {


        public CSessionUser(int _brokerHouseID)
        {
            this.BrokerHouseID = _brokerHouseID;
            this.BrokerDirectoryFolder = GlobalVars.BrokerDirectory;
        }


        public int BrokerHouseID { get; set; }
        public string BrokerDirectoryFolder { get; set; }


        public string SSOLogo
        {
            get
            {
                if (GlobalVars.CurrentLanguage.ToLower() == "en-ca")
                    return GlobalVars.Config.FileManager.RootURL + "/" + GlobalVars.Config.FileManager.BrokerDirectory + "/Logo" + this.BrokerHouseID.ToString() + "_0.png";
                else
                    return GlobalVars.Config.FileManager.RootURL + "/" + GlobalVars.Config.FileManager.BrokerDirectory + "/Logo" + this.BrokerHouseID.ToString() + "_5.png";
            }
        }

        public string CopyRight
        {
            get
            {
                if (this.BrokerHouseID == 1)
                {
                    var tempStr = CResource.getResource("MortgageArchitectCopyright");
                    tempStr = tempStr.Replace("{year}", DateTime.Now.Year.ToString());
                    return tempStr;
                }
                return string.Empty;
            }
        }

        public string PageTitle
        {
            get
            {
                string pageTitle = string.Empty;

                if (this.BrokerHouseID == 1)
                {
                    pageTitle = CResource.getResource("MortgageArchitect");
                }
                else
                {
                    pageTitle = CResource.getResource("RadiusFinancial");
                }

                return pageTitle;
            }
        }
    }
}