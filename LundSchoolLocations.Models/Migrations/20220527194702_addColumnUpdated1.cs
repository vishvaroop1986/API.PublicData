using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LundSchoolLocations.Models.Migrations
{
    public partial class addColumnUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Location",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Location",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Location",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "source",
                table: "Location",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "postalcode",
                table: "Location",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "operation",
                table: "Location",
                newName: "Operation");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Location",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "locationid",
                table: "Location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "locality",
                table: "Location",
                newName: "Locality");

            migrationBuilder.RenameColumn(
                name: "lat",
                table: "Location",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "_long",
                table: "Location",
                newName: "Latitude");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Location",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Location",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Location",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "Source",
                table: "Location",
                newName: "source");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Location",
                newName: "postalcode");

            migrationBuilder.RenameColumn(
                name: "Operation",
                table: "Location",
                newName: "operation");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Location",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Location",
                newName: "locationid");

            migrationBuilder.RenameColumn(
                name: "Locality",
                table: "Location",
                newName: "locality");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Location",
                newName: "lat");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Location",
                newName: "_long");
        }
    }
}
