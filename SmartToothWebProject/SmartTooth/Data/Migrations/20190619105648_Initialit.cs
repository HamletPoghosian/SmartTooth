using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartTooth.Data.Migrations
{
    public partial class Initialit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "DentistTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "DentistTable");
        }
    }
}
