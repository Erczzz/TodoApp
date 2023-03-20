using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class removeusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_People_UserId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DueDate",
                value: new DateTime(2023, 3, 20, 17, 49, 2, 260, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DueDate",
                value: new DateTime(2023, 3, 22, 9, 49, 2, 260, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DueDate",
                value: new DateTime(2023, 3, 21, 9, 49, 2, 260, DateTimeKind.Local).AddTicks(9331));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Todos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_Name = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "DOB", "Email", "First_Name" },
                values: new object[] { 1, new DateTime(2003, 3, 17, 11, 39, 37, 964, DateTimeKind.Local).AddTicks(7026), null, "Administrator" });

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
    }
}
