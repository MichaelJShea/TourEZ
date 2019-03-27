using Microsoft.EntityFrameworkCore.Migrations;

namespace TourEZ.Migrations
{
    public partial class Migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Events",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Events",
                newName: "latitude");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Events",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Events",
                newName: "Latitude");
        }
    }
}
