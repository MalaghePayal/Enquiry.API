using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Model
{
    [Table("Enquiry")]
    public class EnquiryModel
    {
        public int EnquiryId { get; set; }
        public int EnquiryTypeId { get; set; }

        public int EnquiryStatusId { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public string Resolution { get; set; } = string.Empty;
    }
}
