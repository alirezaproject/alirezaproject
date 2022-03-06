using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Mig_AddFavorites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorites_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_LanguageId",
                table: "Favorites",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "InsertTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f799f8cc-c86b-45e9-b985-24463b6c4acf", new DateTime(2022, 3, 6, 19, 44, 41, 449, DateTimeKind.Local).AddTicks(5249), "AQAAAAEAACcQAAAAEF/facMzXPgB3mHheHAtIVX3hFVHLwP3x3CZ3QTLjTf7keIzCIbkEb1RBLelaysm0w==", "d60a8e82-fb38-4204-97ea-78be3a577f80" });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 19, 44, 41, 446, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteId",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 3, 6, 19, 44, 41, 448, DateTimeKind.Local).AddTicks(2046));
        }
    }
}
