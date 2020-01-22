using System.Web;

namespace Business.Comm
{
  public class CReturnCode
  {
    
    public static  void checkErrorCode(string errCode) {
      if (errCode.Trim() == "") return;
      string errorCode = errCode.ToUpper();

      switch (errorCode) { 
        case "":
          break;
      }

      HttpContext.Current.Response.Redirect("/home/error/?m=" + HttpUtility.UrlEncode( errorCode ) , true);      
    }
  }
}