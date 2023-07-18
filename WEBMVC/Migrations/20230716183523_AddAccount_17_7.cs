using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddAccount_17_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usernames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryRoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
