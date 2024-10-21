using Microsoft.AspNetCore.Identity;

namespace ToDo.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string FullName { get; set; } = string.Empty; // Example of an additional property
    }
}
