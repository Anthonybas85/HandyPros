namespace DataModel.Models
{
    public class UserDetailsModel
    {
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BuildUserNavBar { get; set; }
        public int? BrokerID { get; set; }
        public int? TimeZoneID { get; set; }
        public int? UserID { get; set; }
        public int? UserTypeCode { get; set; }
    }
}
