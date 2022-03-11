using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddPortfolio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bb66f00-f7bb-4ee4-9e64-da07024ab0fe", new DateTime(2022, 3, 8, 20, 11, 14, 357, DateTimeKind.Local).AddTicks(5899), "AQAAAAEAACcQAAAAEAQ+BR9fyXD/TDRimyYmRbNRKtYEOuhvbZ8aXmNjvKnq4mVccmvwA1YzmJ635wfxYw==", "71c950a0-e144-434a-82ed-9ff76a4a068b" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 20, 11, 14, 327, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 8, 20, 11, 14, 352, DateTimeKind.Local).AddTicks(6302));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Portfolios");

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
    }
}
