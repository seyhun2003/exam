using Microsoft.AspNetCore.Identity;

namespace examm.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
