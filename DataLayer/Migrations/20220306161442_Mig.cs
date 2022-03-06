using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    InfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.InfoId);
                    table.ForeignKey(
                        name: "FK_Info_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f799f8cc-c86b-45e9-b985-24463b6c4acf", new DateTime(2022, 3, 6, 19, 44, 41, 449, DateTimeKind.Local).AddTicks(5249), "AQAAAAEAACcQAAAAEF/facMzXPgB3mHheHAtIVX3hFVHLwP3x3CZ3QTLjTf7keIzCIbkEb1RBLelaysm0w==", "d60a8e82-fb38-4204-97ea-78be3a577f80" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 19, 44, 41, 446, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 19, 44, 41, 448, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.CreateIndex(
                name: "IX_Info_LanguageId",
                table: "Info",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0b2c09-0e2f-463b-b083-c07aad36f7a6", new DateTime(2022, 3, 6, 18, 39, 9, 543, DateTimeKind.Local).AddTicks(5944), "AQAAAAEAACcQAAAAEA5NuUptJgyRdM/lMMEy1hjNaYRkVYvVnn89DI+bdv0LfMKBGBVuuC9od9WcqKIWug==", "825c5d24-99c1-459b-9cd5-2d9d7768affc" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 18, 39, 9, 540, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 18, 39, 9, 542, DateTimeKind.Local).AddTicks(3274));
        }
    }
}
