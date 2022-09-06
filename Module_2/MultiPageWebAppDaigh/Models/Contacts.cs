using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppDaigh.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Note { get; set; }

        public string Slug => Name?.Replace(" ", "-").ToLower();
    }
}
