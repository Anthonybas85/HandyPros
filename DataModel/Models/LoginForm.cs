using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Business.Comm;

namespace DataModel.Models {
  public class LoginForm: CModel {

    [LocalizedDisplayname("Username")]
    [Required("Username", "Required")]
    public string Username {
      get;
      set;
    }


    [LocalizedDisplayname("Password")]
    [Required("Password", "Required")]
    [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
    public string Password { get; set; }
    public bool EnableCAPTCHA { get; set; }
    public int ApplicationID { get; set; }
    public string Language { get; set; }
    public string ReturnURL { get; set; }
    [LocalizedDisplayname("RememberMe")]
    public bool RememeberMe { get; set; }

    public string RadiusPortalVersion { get; set; }

    public void load() {
      if (GetFailedRequests() > 2)
        this.EnableCAPTCHA = true;
      else
        this.EnableCAPTCHA = false;
    }
    public void SaveFailedLoginCookie() {
      HttpCookie hc = new HttpCookie("FLCKI_" + DateTime.Now.Second.ToString(),"false");
      hc.HttpOnly = true;
      hc.Expires = DateTime.Now.AddMinutes(1);
      HttpContext.Current.Response.Cookies.Add(hc);
  //    HttpContext.Current.Response.Flush();
    }

    private int GetFailedRequests() {
      int iCount = 0;
      foreach (string cookie in HttpContext.Current.Request.Cookies.AllKeys) {
        if (cookie.StartsWith("FLCKI")) {
          iCount++;
        }
      }
      return iCount;
    }

  }
}