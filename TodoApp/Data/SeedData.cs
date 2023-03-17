using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this  ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Name = "Administrator",
                    Id = 1,
                    DOB = DateTime.Now.AddYears(-20)
                });

            modelBuilder.Entity<Todo>().HasData(
                new Todo
                {
                    Id = 4,
                    Title = "Buy Ice Cream",
                    Description = "Eat Ice Cream",
                    Status = false,
                    DueDate = DateTime.Now.AddHours(8)
                },
                new Todo
                {
                    Id = 5,
                    Title = "Learn Data Seeding",
                    Description = "In Jump training",
                    Status = false,
                    DueDate = DateTime.Now.AddDays(2)
                },
                 new Todo
                 {
                     Id = 6,
                     Title = "Learn Fluent Api",
                     Description = "Entity Customization",
                     Status = false,
                     DueDate = DateTime.Now.AddDays(1)
                 });
        }
    }
}
