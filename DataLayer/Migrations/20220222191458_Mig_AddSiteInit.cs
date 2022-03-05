using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddSiteInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d24dbcb6-f4ef-46b1-a31a-67022e000ea4", new DateTime(2022, 2, 22, 22, 44, 58, 59, DateTimeKind.Local).AddTicks(3024), "AQAAAAEAACcQAAAAEPGa6jOKPeLmR/VX+uueSYWmhy3N7PqULc6ZKbUFGzCwjsH89/0sxT7/yLK7QMeM3Q==", "99fac764-6ef1-4a51-807b-d8981ed96135" });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "SiteId", "InsertTime", "IsRemoved", "LanguageId", "LogoAddress", "RemoveTime", "SongAddress", "Title", "UpdateTime" },
                values: new object[] { 2, new DateTime(2022, 2, 22, 22, 44, 58, 57, DateTimeKind.Local).AddTicks(9912), false, 2, "/logo/logo.jpg", null, "/audio/music.mp3", "alireza shokouhian", null });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "SiteId", "InsertTime", "IsRemoved", "LanguageId", "LogoAddress", "RemoveTime", "SongAddress", "Title", "UpdateTime" },
                values: new object[] { 1, new DateTime(2022, 2, 22, 22, 44, 58, 55, DateTimeKind.Local).AddTicks(7570), false, 1, "/logo/logo.jpg", null, "/audio/music.mp3", "علی رضا شکوهیان", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d09c115-a254-4221-9602-0b040699e93f", new DateTime(2022, 2, 20, 23, 56, 50, 890, DateTimeKind.Local).AddTicks(6467), "AQAAAAEAACcQAAAAEHOqcJY55BUVRu+s+vM6TUmVXQGKE4h8YLujVcDnhFTiUhSwzmrwj4AKUT/DTm1Vbg==", "cdf8eef5-1d08-4f96-9976-839e983ff42a" });
        }
    }
}
