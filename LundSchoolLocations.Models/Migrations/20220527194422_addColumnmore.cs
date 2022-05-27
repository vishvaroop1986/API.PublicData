using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LundSchoolLocations.Models.Migrations
{
    public partial class addColumnmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Location",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Location",
                newName: "locationid");

            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Location",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Location",
                newName: "type");

            migrationBuilder.AlterColumn<string>(
                name: "locationid",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "_long",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lat",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "locality",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "operation",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "postalcode",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "source",
                table: "Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_long",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "locality",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "operation",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "postalcode",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "source",
                table: "Location");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Location",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "locationid",
                table: "Location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Location",
                newName: "PostCode");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Location",
                newName: "Latitude");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Location",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
