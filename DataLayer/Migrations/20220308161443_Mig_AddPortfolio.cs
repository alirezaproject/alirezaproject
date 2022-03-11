using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b333b5a-b0bd-453a-81b4-325984bf0f19", new DateTime(2022, 3, 8, 19, 44, 43, 145, DateTimeKind.Local).AddTicks(306), "AQAAAAEAACcQAAAAEIX2k6CQ8nEfjmIUMwb0ktUoB17/mdKq+fvclNWvLzjFmrRrOZThYSdIhEFZAG6sBw==", "c6919542-41f9-4072-acc6-2739480f2fcb" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 19, 44, 43, 141, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 19, 44, 43, 143, DateTimeKind.Local).AddTicks(7141));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c136acbc-6419-4991-ad09-8d6b33ecea95", new DateTime(2022, 3, 8, 18, 50, 59, 634, DateTimeKind.Local).AddTicks(1749), "AQAAAAEAACcQAAAAEA0MrXMdND2euHD+DrNTOMo7YrSY5Zeu8qeq0TiC0L298UQbTkMXz1poGjI0fSzX/g==", "301b2f77-65d3-4589-b8c6-4dcf9ca54335" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 18, 50, 59, 630, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 18, 50, 59, 632, DateTimeKind.Local).AddTicks(8770));
        }
    }
}
