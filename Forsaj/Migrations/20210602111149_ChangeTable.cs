using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class ChangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_CARS_DETAILS");

            migrationBuilder.AddColumn<bool>(
                name: "CONDITIONER",
                table: "TBL_DETAILS",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MODEL_CARS_ID",
                table: "TBL_DETAILS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Model_CarsId",
                table: "TBL_DETAILS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_DETAILS_Model_CarsId",
                table: "TBL_DETAILS",
                column: "Model_CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_DETAILS_TBL_MODEL_CARS_Model_CarsId",
                table: "TBL_DETAILS",
                column: "Model_CarsId",
                principalTable: "TBL_MODEL_CARS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_DETAILS_TBL_MODEL_CARS_Model_CarsId",
                table: "TBL_DETAILS");

            migrationBuilder.DropIndex(
                name: "IX_TBL_DETAILS_Model_CarsId",
                table: "TBL_DETAILS");

            migrationBuilder.DropColumn(
                name: "CONDITIONER",
                table: "TBL_DETAILS");

            migrationBuilder.DropColumn(
                name: "MODEL_CARS_ID",
                table: "TBL_DETAILS");

            migrationBuilder.DropColumn(
                name: "Model_CarsId",
                table: "TBL_DETAILS");

            migrationBuilder.CreateTable(
                name: "TBL_CARS_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABS = table.Column<bool>(type: "bit", nullable: false),
                    DISKI = table.Column<bool>(type: "bit", nullable: false),
                    DERI_SALON = table.Column<bool>(type: "bit", nullable: false),
                    KAMERA = table.Column<bool>(type: "bit", nullable: false),
                    KONDISIONER = table.Column<bool>(type: "bit", nullable: false),
                    KSENON_LAMPALAR = table.Column<bool>(type: "bit", nullable: false),
                    LYUK = table.Column<bool>(type: "bit", nullable: false),
                    PARK_RADAR = table.Column<bool>(type: "bit", nullable: false),
                    QAPANMA = table.Column<bool>(type: "bit", nullable: false),
                    SENSOR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CARS_DETAILS", x => x.ID);
                });
        }
    }
}
