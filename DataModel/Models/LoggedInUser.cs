using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    [Serializable()]
    public class LoggedInUser
    {
        public int UserId { get; set; }
        public int AppLauncherUserId { get; set; }
        public int BrokerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
        public string EmailAddress { get; set; }
        public List<string> Roles { get; set; }
        public string NavHTML { get; set; }

        public int TimeZoneId { get; set; }
        public int UserTypeCode { get; set; }
    }
}
