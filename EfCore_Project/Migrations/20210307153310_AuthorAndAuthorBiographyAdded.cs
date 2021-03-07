using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCore_Project.Migrations
{
    public partial class AuthorAndAuthorBiographyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 225, nullable: true),
                    LastName = table.Column<string>(maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBiography",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Biography = table.Column<string>(maxLength: 999999999, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    IsAlive = table.Column<bool>(nullable: false),
                    PlaceOfLiving = table.Column<string>(maxLength: 250, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBiography", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorBiography_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBiography_AuthorId",
                table: "AuthorBiography",
                column: "AuthorId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBiography");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
