using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class useremailadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 0, 27, 3, 980, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2023, 3, 18, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 16, 27, 3, 980, DateTimeKind.Local).AddTicks(5418));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "People");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2023, 3, 16, 20, 25, 4, 33, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2023, 3, 18, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 12, 25, 4, 33, DateTimeKind.Local).AddTicks(3872));
        }
    }
}
