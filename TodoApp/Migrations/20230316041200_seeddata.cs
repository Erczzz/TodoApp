using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "DOB", "First_Name" },
                values: new object[] { 1, new DateTime(2003, 3, 16, 12, 12, 0, 613, DateTimeKind.Local).AddTicks(3992), "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
