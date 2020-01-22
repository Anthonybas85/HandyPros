namespace Business.Comm
{
  public static class errorCode
  {

    public static string NO_PERMISSION { get { return "NO_PERMISSION"; } }
    public static string UNKNOW_ERROR { get { return "UNKNOW_ERROR"; } }
    public static string CONCURRENCY_ERROR { get { return "CONCURRENCY_ERROR"; } }
    public static string RECORD_EXISTS { get { return "This record already exists"; } }
    
    public static string USER_EXISTS { get { return "USER_EXISTS"; } }
    public static string USER_GROUPS_EXISTS { get { return "USER_GROUPS_EXISTS"; } }
    public static string TEAM_TYPE_EXISTS { get { return "Another team type is already activated"; } }
    public static string BROKER_HOUSE_EXISTS { get { return "BROKER_HOUSE_EXISTS"; } }
    public static string PROFILE_FIELD_EXISTS { get { return "PROFILE_FIELD_EXISTS"; } }
    public static string REGION_EXISTS { get { return "REGION_EXISTS"; } }
    public static string TEAM_EXISTS { get { return "TEAM_EXISTS"; } }
    public static string BROKERHOUSE_REGION_EXISTS { get { return "BROKERHOUSE_REGION_EXISTS"; } }
    public static string BRANCH_EXISTS { get { return "BRANCH_EXISTS"; } }
    public static string BROKER_EXISTS { get { return "BROKER_EXISTS"; } }
    public static string BROKER_BRANCH_EXISTS { get { return "BROKER_BRANCH_EXISTS"; } }
    public static string PAYCODE_EXISTS { get { return "PAYCODE_EXISTS"; } }
    public static string PAYCODE_NAME_NOT_UNIQUE { get { return "PAYCODE_NAME_NOT_UNIQUE"; } }
    public static string APPLICATION_EXISTS { get { return "APPLICATION_EXISTS"; } }
    public static string LOOKUP_EXISTS { get { return "LOOKUP_EXISTS"; } }
    public static string SERVICEAREA_EXISTS { get { return "SERVICEAREA_EXISTS"; } }
    public static string WEBSITE_PROFILE_EXISTS { get { return "WEBSITE_PROFILE_EXISTS"; } }

    public static string LOGIN_SVC_ERR_UNKNOW_USERNAME { get { return "LOGIN_SVC_ERR_UNKNOW_USERNAME"; } }
    //public static string LOGIN_SVC_ERR_WRONG_PASSWORD { get { return "LOGIN_SVC_ERR_WRONG_PASSWORD"; } }
    public static string LOGIN_SVC_ERR_INACTIVE_USER { get { return "LOGIN_SVC_ERR_INACTIVE_USER"; } }
    public static string LOGIN_SVC_ERR_APPLICATION_NO_PERMISSION { get { return "LOGIN_SVC_ERR_APPLICATION_NO_PERMISSION"; } }       
  }


}
