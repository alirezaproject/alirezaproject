using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddSiteInit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundAddress",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d33cd6-cb9c-442b-81f5-be854c35423e", new DateTime(2022, 2, 22, 22, 50, 13, 969, DateTimeKind.Local).AddTicks(5340), "AQAAAAEAACcQAAAAEA+ye9Ztfk+yTKzGjc8+oaCUWV+xusv6ab+xFY8WR3m3Gor0ba6eSZ5kdxqBX0shsg==", "4df4bf02-9e0c-4177-a2ca-378de1f28512" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                columns: new[] { "BackgroundAddress", "InsertTime" },
                values: new object[] { "/img/home-bg.jpg", new DateTime(2022, 2, 22, 22, 50, 13, 965, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                columns: new[] { "BackgroundAddress", "InsertTime" },
                values: new object[] { "/img/home-bg.jpg", new DateTime(2022, 2, 22, 22, 50, 13, 968, DateTimeKind.Local).AddTicks(1993) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundAddress",
                table: "Sites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d24dbcb6-f4ef-46b1-a31a-67022e000ea4", new DateTime(2022, 2, 22, 22, 44, 58, 59, DateTimeKind.Local).AddTicks(3024), "AQAAAAEAACcQAAAAEPGa6jOKPeLmR/VX+uueSYWmhy3N7PqULc6ZKbUFGzCwjsH89/0sxT7/yLK7QMeM3Q==", "99fac764-6ef1-4a51-807b-d8981ed96135" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 22, 44, 58, 55, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 22, 44, 58, 57, DateTimeKind.Local).AddTicks(9912));
        }
    }
}
