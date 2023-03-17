using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data.ModelTableMapping
{
    public static class UserModelMapping
    {
        // extension methods -> syntax
        public static void UserModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("People")
                .Property("Name")
                .HasColumnName("First_Name")
                .HasColumnType("ntext");
            modelBuilder.Entity<User>().Ignore(u => u.Age);
        }
    }
}
