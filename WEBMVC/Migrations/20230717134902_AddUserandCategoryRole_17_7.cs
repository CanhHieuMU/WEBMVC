using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddUserandCategoryRole_17_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryRoleID",
                table: "Accounts",
                newName: "CategoryRoleId");

            migrationBuilder.CreateTable(
                name: "CategoryRoles",
                columns: table => new
                {
                    CategoryRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRoles", x => x.CategoryRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CategoryRoleId",
                table: "Accounts",
                column: "CategoryRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_CategoryRoles_CategoryRoleId",
                table: "Accounts",
                column: "CategoryRoleId",
                principalTable: "CategoryRoles",
                principalColumn: "CategoryRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_CategoryRoles_CategoryRoleId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "CategoryRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CategoryRoleId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "CategoryRoleId",
                table: "Accounts",
                newName: "CategoryRoleID");
        }
    }
}
