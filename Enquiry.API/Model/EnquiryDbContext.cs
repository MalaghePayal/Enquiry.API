using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Model
{
    public class EnquiryDbContext:DbContext
    {
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options):base(options) 
        {
            
        }


    }
}
