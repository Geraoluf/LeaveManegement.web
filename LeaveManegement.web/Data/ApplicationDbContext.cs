﻿using LeaveManegement.web.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManegement.web.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

    }
}
