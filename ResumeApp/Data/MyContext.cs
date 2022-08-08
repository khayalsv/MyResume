using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Home> Homes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Programming> Programmings { get; set; }



    }
}
