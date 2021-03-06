﻿using Microsoft.EntityFrameworkCore;
using VueJsDemo.Api.Models;

namespace VueJsDemo.Api.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public AppDbContext() { }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Example of overriding default Plural Entity Table Name to use Singular Entity Table Name
            // modelBuilder.Entity<Contact>().ToTable("Contact");

            // Example of defining a composite key to ensure only one record for the unique combination of the two properties
            // modelBuilder.Entity<CourseAssignment>()
            //    .HasKey(c => new { c.CourseID, c.InstructorID });
        }

    }
}
