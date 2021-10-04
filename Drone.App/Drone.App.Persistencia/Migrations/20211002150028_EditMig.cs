using Microsoft.EntityFrameworkCore.Migrations;

namespace Drone.App.Persistencia.Migrations
{
    public partial class EditMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordClie",
                table: "Encargados",
                newName: "PasswordEncarg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordEncarg",
                table: "Encargados",
                newName: "PasswordClie");
        }
    }
}
