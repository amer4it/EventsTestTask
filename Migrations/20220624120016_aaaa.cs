using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApp.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Event");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Event",
                type: "int",
                nullable: true);
        }
    }
}
