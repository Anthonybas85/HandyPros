using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SSO.Form.Common;

namespace SSO.Form.Models
{
    public class ResetPasswordFrm : CModel
    {
        [LocalizedDisplayname("EmailAddress")]
        [Required("EmailAddress", "Required")]
        public string EmailAddress { get; set; }
    }
}