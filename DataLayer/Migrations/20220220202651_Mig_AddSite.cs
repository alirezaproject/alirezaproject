using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    SiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SiteId);
                    table.ForeignKey(
                        name: "FK_Sites_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d09c115-a254-4221-9602-0b040699e93f", new DateTime(2022, 2, 20, 23, 56, 50, 890, DateTimeKind.Local).AddTicks(6467), "AQAAAAEAACcQAAAAEHOqcJY55BUVRu+s+vM6TUmVXQGKE4h8YLujVcDnhFTiUhSwzmrwj4AKUT/DTm1Vbg==", "cdf8eef5-1d08-4f96-9976-839e983ff42a" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LangName" },
                values: new object[] { 2, "en-US" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LangName" },
                values: new object[] { 1, "fa-IR" });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_LanguageId",
                table: "Sites",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2033394-62ed-4e25-a048-56f28f0c6cb5", new DateTime(2022, 2, 20, 22, 30, 13, 330, DateTimeKind.Local).AddTicks(706), "AQAAAAEAACcQAAAAECT0/J0gDq+QMd+1xJVPcYO6c2qiANOB0Z6/mq6BbMwx6oXv+96iyhJEgQDkn2qgxw==", "16450ec7-5211-40d8-b6e9-52c35e96629a" });
        }
    }
}
