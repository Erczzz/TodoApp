using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class seedtodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[,]
                {
                    { 4, "Eat Ice Cream", new DateTime(2023, 3, 16, 20, 25, 4, 33, DateTimeKind.Local).AddTicks(3865), false, "Buy Ice Cream" },
                    { 5, "In Jump training", new DateTime(2023, 3, 18, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3871), false, "Learn Data Seeding" },
                    { 6, "Entity Customization", new DateTime(2023, 3, 17, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3872), false, "Learn Fluent Api" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 12, 12, 0, 613, DateTimeKind.Local).AddTicks(3992));
        }
    }
}
