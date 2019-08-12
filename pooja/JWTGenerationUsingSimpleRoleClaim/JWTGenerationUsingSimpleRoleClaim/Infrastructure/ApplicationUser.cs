﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace JWTGenerationUsingSimpleRoleClaim.Infrastructure
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string Location { get; set; }

        //Rest of code is removed for brevity
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("Gender", "Male"));
            return userIdentity;
        }
    }
}