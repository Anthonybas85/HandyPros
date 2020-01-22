using System;
using System.Web.Mvc;

namespace Business.Comm
{
#if Release
  [RequireSSL(RequireSecure=false)]
#endif
    public class CController : Controller
    {

        public string errorCode;
        public CController()
        {
            errorCode = string.Empty;

        }


        public void checkErrorCode()
        {
            this.checkErrorCode(this.errorCode);
        }

        public void checkErrorCode(string errCode)
        {
            CReturnCode.checkErrorCode(errCode);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr");
            base.OnActionExecuting(filterContext);
        }

        public void checkDate(object startD, object endD)
        {
            try
            {
                if (startD == null && endD == null)
                {
                    return;
                }
                else if (startD != null && endD == null)
                {
                    return;
                }
                else if (startD == null && endD != null)
                {
                    //this.ModelState.AddModelError("", CResource.getResource("DateValidatorMessage"));
                    return;
                }

                DateTime sd = Convert.ToDateTime(startD);
                DateTime ed = Convert.ToDateTime(endD);

                if (sd >= ed)
                    this.ModelState.AddModelError("", CResource.getResource("DateValidatorMessage"));
            }
            catch (Exception) { }
        }
    }
}