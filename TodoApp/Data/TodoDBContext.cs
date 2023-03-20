using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;
using TodoApp.Models;
using TodoApp.Data.ModelTableMapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TodoApp.Data
{
    public class TodoDBContext : IdentityDbContext
    {
        // define the database and structure of the database will be managed over here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {          

            // where is  db server?
            // connection string

            // Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            /*
            1. Server = localhost, ip / instance ofserver  - MSSQLServer process
            2. How to access this - windows authentication or db authentication [sa - password]
            3. database name - TodoDB
             */

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=TodoDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api customize the tables schema
            modelBuilder.UserModel();
            base.OnModelCreating(modelBuilder);

            // seed some basic data
            // administrator user in the user table
            modelBuilder.SeedDefaultData();
        }

        // tables in db  and entities in application mapping

        public DbSet<Todo> Todos { get; set; } // plural many
        // public DbSet<User> Users { get; set; }  

    }
}
