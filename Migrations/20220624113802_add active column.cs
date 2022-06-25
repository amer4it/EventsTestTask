using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsApp.Migrations
{
    public partial class addactivecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Active_status",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active_status",
                table: "Event");
        }
    }
}
