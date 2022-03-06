using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_EditAboutMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageAddress",
                table: "AboutMe",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageAddress",
                table: "AboutMe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c3024b4-553a-40bd-b2da-ed2321394bb0", new DateTime(2022, 3, 6, 18, 19, 48, 516, DateTimeKind.Local).AddTicks(3743), "AQAAAAEAACcQAAAAEO+pdsSJzhodBVBvrUroZb9ROAJ3vANKVJd83NPZfY6iLKDpTD6DsUTfmaqZNwyQ9w==", "ad3e04ae-35bd-4ee9-b425-97e82a09767b" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 18, 19, 48, 512, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 18, 19, 48, 514, DateTimeKind.Local).AddTicks(9318));
        }
    }
}
