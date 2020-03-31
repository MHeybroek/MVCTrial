
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTrial_Core.Users
{
    class ApplicationUser : IdentityUser
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
