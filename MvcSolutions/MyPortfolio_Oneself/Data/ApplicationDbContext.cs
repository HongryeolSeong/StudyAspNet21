using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio_Oneself.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyPortfolio_Oneself.Models.Contact> Contacts { get; set; }
        public DbSet<MyPortfolio_Oneself.Models.Board> Boards { get; set; }
    }
}