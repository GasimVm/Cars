using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class AddHPower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HPower",
                table: "TBL_POST",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HPower",
                table: "TBL_POST");
        }
    }
}
