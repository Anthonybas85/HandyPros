using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DataModels.Models
{
    public class DocumentModel
    {
        public Guid ID { get; set; }
        public int BrokerID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string BrokerFirstName { get; set; }
        public string BrokerLastName { get; set; }

        [Required]
        public int DocumentTypeID { get; set; }

        [Required]
        public HttpPostedFileBase File { get; set; }

        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime DateUploaded { get; set; }
        public int UploadedBy { get; set; }
        public string UploadedByName { get; set; }
    }
}
