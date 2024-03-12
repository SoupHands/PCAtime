using Microsoft.AspNetCore.Identity;

namespace PCAtime.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string RoleName { get; set; }

    }

}
