using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApp.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active_status",
                table: "Event",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Event",
                newName: "Active_status");
        }
    }
}
