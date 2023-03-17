using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class onetomanytodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Todos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 17, 11, 39, 37, 964, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 19, 39, 37, 964, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2023, 3, 19, 11, 39, 37, 964, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2023, 3, 18, 11, 39, 37, 964, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_People_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "People",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_People_UserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todos");

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
    }
}
