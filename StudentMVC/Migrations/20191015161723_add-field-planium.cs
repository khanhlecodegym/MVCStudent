using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentMVC.Migrations
{
    public partial class addfieldplanium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPlatinum",
                table: "Students",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlatinum",
                table: "Students");
        }
    }
}
