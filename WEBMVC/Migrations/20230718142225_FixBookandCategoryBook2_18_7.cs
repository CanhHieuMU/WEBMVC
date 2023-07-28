using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class FixBookandCategoryBook2_18_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePublic = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryBooks",
                columns: table => new
                {
                    CategoryBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBooks", x => x.CategoryBookId);
                });

            migrationBuilder.CreateTable(
                name: "BookCategoryBook",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    CategoryBooksCategoryBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategoryBook", x => new { x.BooksBookId, x.CategoryBooksCategoryBookId });
                    table.ForeignKey(
                        name: "FK_BookCategoryBook_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategoryBook_CategoryBooks_CategoryBooksCategoryBookId",
                        column: x => x.CategoryBooksCategoryBookId,
                        principalTable: "CategoryBooks",
                        principalColumn: "CategoryBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategoryBook_CategoryBooksCategoryBookId",
                table: "BookCategoryBook",
                column: "CategoryBooksCategoryBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategoryBook");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "CategoryBooks");
        }
    }
}
