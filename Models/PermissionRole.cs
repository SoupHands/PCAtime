﻿using Microsoft.AspNetCore.Identity;

namespace PCAtime.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string RoleName { get; set; }

    }

}
