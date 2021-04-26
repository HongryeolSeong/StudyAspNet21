using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyPortpolio.Models;

namespace MyPortpolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyPortpolio.Models.Contact> Contacts { get; set; }
        public DbSet<MyPortpolio.Models.Account> Account { get; set; }
        public DbSet<MyPortpolio.Models.Board> Boards { get; set; }
        public DbSet<MyPortpolio.Models.Manage> Manages { get; set; }

    }
}