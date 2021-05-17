using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class AddedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABS = table.Column<bool>(type: "bit", nullable: false),
                    DISK = table.Column<bool>(type: "bit", nullable: false),
                    SALON = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_SISTEM = table.Column<bool>(type: "bit", nullable: false),
                    PARK_RADAR = table.Column<bool>(type: "bit", nullable: false),
                    KSENON = table.Column<bool>(type: "bit", nullable: false),
                    LYUK = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DETAILS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_YEAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATE_YEAR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_YEAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_POST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    KREDIT = table.Column<bool>(type: "bit", nullable: false),
                    BARTER = table.Column<bool>(type: "bit", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    COUNT = table.Column<int>(type: "int", nullable: false),
                    PROBEG = table.Column<int>(type: "int", nullable: false),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: true),
                    POWER_ID = table.Column<int>(type: "int", nullable: true),
                    YEAR_ID = table.Column<int>(type: "int", nullable: true),
                    SPEED_TYPE_ID = table.Column<int>(type: "int", nullable: true),
                    Speed_TypeId = table.Column<int>(type: "int", nullable: true),
                    TRANMISSION_ID = table.Column<int>(type: "int", nullable: true),
                    TransmissionId = table.Column<int>(type: "int", nullable: true),
                    FUEL_TYPE_ID = table.Column<int>(type: "int", nullable: true),
                    Fuel_TypeId = table.Column<int>(type: "int", nullable: true),
                    CURRENCY_ID = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    COLOR_ID = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    COUNTRY_ID = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CITY_ID = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    BAN_TYPE_ID = table.Column<int>(type: "int", nullable: true),
                    Ban_TypeId = table.Column<int>(type: "int", nullable: true),
                    COMPANY_ID = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    MODEL_CARS_ID = table.Column<int>(type: "int", nullable: true),
                    Model_CarsId = table.Column<int>(type: "int", nullable: true),
                    DETAIL_ID = table.Column<int>(type: "int", nullable: true),
                    DetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_POST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_BAN_TYPE_Ban_TypeId",
                        column: x => x.Ban_TypeId,
                        principalTable: "TBL_BAN_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_CITY_CityId",
                        column: x => x.CityId,
                        principalTable: "TBL_CITY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_COLOR_ColorId",
                        column: x => x.ColorId,
                        principalTable: "TBL_COLOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "TBL_COMPANY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_COUNTRY_CountryId",
                        column: x => x.CountryId,
                        principalTable: "TBL_COUNTRY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_CURRENCY_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "TBL_CURRENCY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_DETAILS_DetailsId",
                        column: x => x.DetailsId,
                        principalTable: "TBL_DETAILS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_FUEL_TYPE_Fuel_TypeId",
                        column: x => x.Fuel_TypeId,
                        principalTable: "TBL_FUEL_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_MODEL_CARS_Model_CarsId",
                        column: x => x.Model_CarsId,
                        principalTable: "TBL_MODEL_CARS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_POWER_POWER_ID",
                        column: x => x.POWER_ID,
                        principalTable: "TBL_POWER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_SPEED_TYPE_Speed_TypeId",
                        column: x => x.Speed_TypeId,
                        principalTable: "TBL_SPEED_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_TRANSMISSION_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "TBL_TRANSMISSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TBL_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_POST_TBL_YEAR_YEAR_ID",
                        column: x => x.YEAR_ID,
                        principalTable: "TBL_YEAR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POST_IMAGES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POST_ID = table.Column<int>(type: "int", nullable: false),
                    IMAGE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POST_IMAGES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_POST_IMAGES_TBL_IMAGE_IMAGE_ID",
                        column: x => x.IMAGE_ID,
                        principalTable: "TBL_IMAGE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POST_IMAGES_TBL_POST_POST_ID",
                        column: x => x.POST_ID,
                        principalTable: "TBL_POST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_POST_IMAGES_IMAGE_ID",
                table: "POST_IMAGES",
                column: "IMAGE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POST_IMAGES_POST_ID",
                table: "POST_IMAGES",
                column: "POST_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_Ban_TypeId",
                table: "TBL_POST",
                column: "Ban_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_CityId",
                table: "TBL_POST",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_ColorId",
                table: "TBL_POST",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_CompanyId",
                table: "TBL_POST",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_CountryId",
                table: "TBL_POST",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_CurrencyId",
                table: "TBL_POST",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_DetailsId",
                table: "TBL_POST",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_Fuel_TypeId",
                table: "TBL_POST",
                column: "Fuel_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_Model_CarsId",
                table: "TBL_POST",
                column: "Model_CarsId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_POWER_ID",
                table: "TBL_POST",
                column: "POWER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_Speed_TypeId",
                table: "TBL_POST",
                column: "Speed_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_TransmissionId",
                table: "TBL_POST",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_USER_ID",
                table: "TBL_POST",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_YEAR_ID",
                table: "TBL_POST",
                column: "YEAR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POST_IMAGES");

            migrationBuilder.DropTable(
                name: "TBL_POST");

            migrationBuilder.DropTable(
                name: "TBL_DETAILS");

            migrationBuilder.DropTable(
                name: "TBL_YEAR");
        }
    }
}
