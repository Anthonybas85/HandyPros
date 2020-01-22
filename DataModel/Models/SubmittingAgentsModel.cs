using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using DataModels.Common;

namespace DataModels.Models
{
    public class SubmittingAgentsModel
    {
        public int ID { get; set; }

        //[LocalizedDisplayname("Agent")]
        public string Agent { get; set; }

        //[LocalizedDisplayname("FirstName")]
        //[Required(ErrorMessageResourceName = "FirstNameRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string FirstName { get; set; }

        //[LocalizedDisplayname("LastName")]
        //[Required(ErrorMessageResourceName = "LastNameRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string LastName { get; set; }

        //[LocalizedDisplayname("LicenseNumber")]
        //[Required(ErrorMessageResourceName = "LicenseNumberRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string LicenseNumber { get; set; }

        //[LocalizedDisplayname("Address")]
        //[Required(ErrorMessageResourceName = "AddressRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string Address { get; set; }

        //[LocalizedDisplayname("City")]
        //[Required(ErrorMessageResourceName = "CityRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string City { get; set; }

        //[LocalizedDisplayname("Fax")]
        public string Fax { get; set; }

        //[LocalizedDisplayname("PostalCode")]
        //[Required(ErrorMessageResourceName = "PostalCodeRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string PostalCode { get; set; }

        //[LocalizedDisplayname("PhoneNumber")]
        //[Required(ErrorMessageResourceName = "PhoneNumberRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public string PhoneNumber { get; set; }

        //[LocalizedDisplayname("EmailAddress")]
        //[Required(ErrorMessageResourceName = "EmailAddressRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        //[RegularExpression(@"\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*", ErrorMessageResourceType = typeof(Resources.Common), ErrorMessageResourceName = "InvalidEmail")]
        public string EmailAddress { get; set; }

        //[LocalizedDisplayname("Status")]
        //[Required(ErrorMessageResourceName = "StatusRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public int? StatusID { get; set; }
        public string Status { get; set; }
        public IEnumerable StatusDD { get; set; }

        //[LocalizedDisplayname("StartDate")]
        //[Required(ErrorMessageResourceName = "StartDateRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public DateTime? StartDate { get; set; }

        //[LocalizedDisplayname("EndDate")]
        public DateTime? EndDate { get; set; }

        //[LocalizedDisplayname("Notes")]
        public string Notes { get; set; }

        //[LocalizedDisplayname("Broker")]
        //[Required(ErrorMessageResourceName = "BrokerRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public int BrokerID { get; set; }
        public string BrokerName { get; set; }

        public int BranchID { get; set; }
    }
}
