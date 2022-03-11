using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    IsRight = table.Column<bool>(type: "bit", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_LanguageId",
                table: "Experiences",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e7cc44-95ee-4b16-9fec-9cba033e0480", new DateTime(2022, 3, 6, 21, 40, 31, 550, DateTimeKind.Local).AddTicks(7867), "AQAAAAEAACcQAAAAEIF4NU/PrEkekAPddQD+zUsyO1zjWu2QBFN2SRaEJmQk0HvzoMnkBd4rBafgVuxhBg==", "70e8f0e1-f7e5-4fb7-be0f-bff54e220483" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 21, 40, 31, 546, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 21, 40, 31, 548, DateTimeKind.Local).AddTicks(9173));
        }
    }
}
