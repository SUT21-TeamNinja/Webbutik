﻿
using Microsoft.AspNetCore.Identity;

namespace Webbutik.Models
{
    public class User  : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? RoleId { get; set; }
        public string? Role { get; set; }

    }
}
