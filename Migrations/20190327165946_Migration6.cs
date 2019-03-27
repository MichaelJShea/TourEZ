using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourEZ.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "latitude",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Events",
                newName: "startTime");

            migrationBuilder.RenameColumn(
                name: "start",
                table: "Events",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "end",
                table: "Events",
                newName: "endTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "endDate",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endDate",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "Events",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Events",
                newName: "start");

            migrationBuilder.RenameColumn(
                name: "endTime",
                table: "Events",
                newName: "end");

            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "Events",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "Events",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
