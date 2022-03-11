using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactUsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactUsId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b20226-4391-4a8e-bdc1-f17f0d792a22", new DateTime(2022, 3, 7, 13, 26, 31, 741, DateTimeKind.Local).AddTicks(6476), "AQAAAAEAACcQAAAAEF1iRSAMfTJh2OkdYjZDfKIrFE0OwW00K0k5kG1PvQLLAexDpXl9/HinKBFYE/IPXA==", "79557615-3861-4d71-bf61-bee1c4b98236" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 7, 13, 26, 31, 737, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 7, 13, 26, 31, 740, DateTimeKind.Local).AddTicks(2772));
        }
    }
}
