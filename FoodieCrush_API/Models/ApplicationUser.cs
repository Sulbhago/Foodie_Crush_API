using Microsoft.AspNetCore.Identity;

namespace FoodieCrush_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
