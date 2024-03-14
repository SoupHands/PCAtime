using Microsoft.AspNetCore.Identity;
using System;

public class ApplicationUser : IdentityUser
{
    public required string UserName { get; set; }

    public required string Password { get; set; }

}

