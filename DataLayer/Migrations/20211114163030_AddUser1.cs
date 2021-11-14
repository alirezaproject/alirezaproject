using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class AddUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "InsertTime", "NormalizedEmail", "NormalizedUserName", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "aa81437b-fe13-4754-a395-37af8263df35", true, new DateTime(2021, 11, 14, 20, 0, 30, 62, DateTimeKind.Local).AddTicks(5271), "SHEKOOHIANPROJECT@GMAIL.COM", "SHEKOOHIANPROJECT@GMAIL.COM", true, "7d04ccc6-4cef-4c3a-8103-7025b0da1a28" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "InsertTime", "NormalizedEmail", "NormalizedUserName", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "9c07e543-7180-43dc-90f5-0b01055903da", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null });
        }
    }
}
