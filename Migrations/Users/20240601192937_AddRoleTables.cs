using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyCoreWebApplication.Migrations.Users
{
    public partial class AddRoleTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "SignedInModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SignedInModels_RoleId",
                table: "SignedInModels",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SignedInModels_Roles_RoleId",
                table: "SignedInModels",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignedInModels_Roles_RoleId",
                table: "SignedInModels");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_SignedInModels_RoleId",
                table: "SignedInModels");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "SignedInModels");
        }
    }
}
