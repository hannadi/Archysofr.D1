﻿using System;
using Archysoft.D1.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Archysoft.D1.Data
{
    public class DataContext : IdentityDbContext<User, Role, Guid>
    {
        private readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }
    }
}
