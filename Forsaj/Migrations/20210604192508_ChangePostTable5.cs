using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class ChangePostTable5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ban_Type_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "City_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Color_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Company_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Country_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Currency_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Details_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Fuel_Type_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Model_Cars_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Speed_Type_Id",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "Transmission_Id",
                table: "TBL_POST");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ban_Type_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "City_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Country_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Currency_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Details_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fuel_Type_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Model_Cars_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Speed_Type_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Transmission_Id",
                table: "TBL_POST",
                type: "int",
                nullable: true);
        }
    }
}
