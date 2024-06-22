using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyCoreWebApplication.Migrations.Users
{
    public partial class UpdateSignedInModelsWithRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "SignedInModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "SignedInModels");
        }
    }
}
