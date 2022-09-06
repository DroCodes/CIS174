using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppDaigh.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contacts> Contact { get; set; }
    }
}
