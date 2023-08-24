﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShopApp.Identity
{
    public class ApplicationContext  : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        { 
        
        }
    }
}
