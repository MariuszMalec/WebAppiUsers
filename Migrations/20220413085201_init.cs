using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppiUsers.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Sso = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 1, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(816), "Patryk", "Szwermer", 222222221 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 2, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1939), "Przemyslaw", "Sawicki", 222222222 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 3, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1941), "Marcin", "Dabrowski", 222222223 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 4, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1942), "Piotr", "Katny", 222222224 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 5, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1943), "Marcin", "Dudzic", 222222225 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 6, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1946), "Maciej", "Krakowiak", 222222226 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 7, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1947), "Mateusz", "Cebula", 222222227 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 8, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1947), "Jakub", "Nowikowski", 222222228 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 9, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1948), "Jan", "Choma", 222222229 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 10, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1949), "Marcin", "Przypek", 322222221 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 11, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1950), "Michal", "Sosnowski", 422222221 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "FirstName", "LastName", "Sso" },
                values: new object[] { 12, new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1951), "Maciej", "Tyszka", 522222221 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
