using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsReminder.DataAccess.Migrations
{
    public partial class EditGlobalEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "GlobalEvents",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "GlobalEvents",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "GlobalEvents",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "GlobalEvents",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3000);
        }
    }
}
