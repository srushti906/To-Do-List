using Microsoft.AspNetCore.Identity;

namespace ToDo.Models
{
    public class ApplicationUser : IdentityUser
    {
        // You can add additional properties here
        // For example:
        public string FullName { get; set; } = string.Empty; // Example of an additional property
    }
}
