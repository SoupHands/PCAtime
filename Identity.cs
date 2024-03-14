using Microsoft.AspNetCore.Identity;

namespace PCAtime
{
    public class ApplicationUser : IdentityUser
    {
        public string RoleName { get; set; } = "intern";
    }

}
