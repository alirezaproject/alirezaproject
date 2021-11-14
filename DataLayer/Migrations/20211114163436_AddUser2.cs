using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class AddUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d23a60e-3dbf-45e6-800b-62fd0df88d43", new DateTime(2021, 11, 14, 20, 4, 35, 882, DateTimeKind.Local).AddTicks(9140), "AQAAAAEAACcQAAAAEKifuQ2lhdhGxl0KCuIdzUe7zmk4GEt1HgdIStlzjwxY9BCshNSj4rUMZbGlICz94A==", "02a6e0cb-cfae-4fe7-8f21-11cbed577b5b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa81437b-fe13-4754-a395-37af8263df35", new DateTime(2021, 11, 14, 20, 0, 30, 62, DateTimeKind.Local).AddTicks(5271), null, "7d04ccc6-4cef-4c3a-8103-7025b0da1a28" });
        }
    }
}
