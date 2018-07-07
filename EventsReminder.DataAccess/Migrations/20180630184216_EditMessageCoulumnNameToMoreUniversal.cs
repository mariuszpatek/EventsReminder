using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsReminder.DataAccess.Migrations
{
    public partial class EditMessageCoulumnNameToMoreUniversal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Messages",
                newName: "MessageTarget");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Notifications",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageTarget",
                table: "Messages",
                newName: "UserEmail");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Notifications",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: true);
        }
    }
}
