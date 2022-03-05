using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                    table.ForeignKey(
                        name: "FK_Titles_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96df0257-f98e-4067-a4ed-46acfccf204e", new DateTime(2022, 2, 22, 23, 5, 39, 189, DateTimeKind.Local).AddTicks(449), "AQAAAAEAACcQAAAAELLD/l8HqsP1bwRxVCZGx/VwQC7n38l0ydAfXKkVZlrtl4cEjrya14X7gHRrFBSDqg==", "dd316aab-f36c-43eb-83ee-1a46b9092163" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 23, 5, 39, 185, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 23, 5, 39, 187, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.CreateIndex(
                name: "IX_Titles_LanguageId",
                table: "Titles",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");

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
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 22, 50, 13, 965, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 2, 22, 22, 50, 13, 968, DateTimeKind.Local).AddTicks(1993));
        }
    }
}
