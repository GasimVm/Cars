using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class ChangePostTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_POWER_POWER_ID",
                table: "TBL_POST");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_USERS_USER_ID",
                table: "TBL_POST");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_YEAR_YEAR_ID",
                table: "TBL_POST");

            migrationBuilder.RenameColumn(
                name: "SPEED_TYPE_ID",
                table: "TBL_POST",
                newName: "Speed_Type_Id");

            migrationBuilder.RenameColumn(
                name: "MODEL_CARS_ID",
                table: "TBL_POST",
                newName: "Model_Cars_Id");

            migrationBuilder.RenameColumn(
                name: "FUEL_TYPE_ID",
                table: "TBL_POST",
                newName: "Fuel_Type_Id");

            migrationBuilder.RenameColumn(
                name: "CURRENCY_ID",
                table: "TBL_POST",
                newName: "Currency_Id");

            migrationBuilder.RenameColumn(
                name: "COUNTRY_ID",
                table: "TBL_POST",
                newName: "Country_Id");

            migrationBuilder.RenameColumn(
                name: "COMPANY_ID",
                table: "TBL_POST",
                newName: "Company_Id");

            migrationBuilder.RenameColumn(
                name: "COLOR_ID",
                table: "TBL_POST",
                newName: "Color_Id");

            migrationBuilder.RenameColumn(
                name: "CITY_ID",
                table: "TBL_POST",
                newName: "City_Id");

            migrationBuilder.RenameColumn(
                name: "BAN_TYPE_ID",
                table: "TBL_POST",
                newName: "Ban_Type_Id");

            migrationBuilder.RenameColumn(
                name: "YEAR_ID",
                table: "TBL_POST",
                newName: "YearId");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "TBL_POST",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TRANMISSION_ID",
                table: "TBL_POST",
                newName: "Transmission_Id");

            migrationBuilder.RenameColumn(
                name: "POWER_ID",
                table: "TBL_POST",
                newName: "PowerId");

            migrationBuilder.RenameColumn(
                name: "DETAIL_ID",
                table: "TBL_POST",
                newName: "Details_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_YEAR_ID",
                table: "TBL_POST",
                newName: "IX_TBL_POST_YearId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_USER_ID",
                table: "TBL_POST",
                newName: "IX_TBL_POST_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_POWER_ID",
                table: "TBL_POST",
                newName: "IX_TBL_POST_PowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_POWER_PowerId",
                table: "TBL_POST",
                column: "PowerId",
                principalTable: "TBL_POWER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_USERS_UserId",
                table: "TBL_POST",
                column: "UserId",
                principalTable: "TBL_USERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_YEAR_YearId",
                table: "TBL_POST",
                column: "YearId",
                principalTable: "TBL_YEAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_POWER_PowerId",
                table: "TBL_POST");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_USERS_UserId",
                table: "TBL_POST");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_YEAR_YearId",
                table: "TBL_POST");

            migrationBuilder.RenameColumn(
                name: "Speed_Type_Id",
                table: "TBL_POST",
                newName: "SPEED_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "Model_Cars_Id",
                table: "TBL_POST",
                newName: "MODEL_CARS_ID");

            migrationBuilder.RenameColumn(
                name: "Fuel_Type_Id",
                table: "TBL_POST",
                newName: "FUEL_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "Currency_Id",
                table: "TBL_POST",
                newName: "CURRENCY_ID");

            migrationBuilder.RenameColumn(
                name: "Country_Id",
                table: "TBL_POST",
                newName: "COUNTRY_ID");

            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "TBL_POST",
                newName: "COMPANY_ID");

            migrationBuilder.RenameColumn(
                name: "Color_Id",
                table: "TBL_POST",
                newName: "COLOR_ID");

            migrationBuilder.RenameColumn(
                name: "City_Id",
                table: "TBL_POST",
                newName: "CITY_ID");

            migrationBuilder.RenameColumn(
                name: "Ban_Type_Id",
                table: "TBL_POST",
                newName: "BAN_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "YearId",
                table: "TBL_POST",
                newName: "YEAR_ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TBL_POST",
                newName: "USER_ID");

            migrationBuilder.RenameColumn(
                name: "Transmission_Id",
                table: "TBL_POST",
                newName: "TRANMISSION_ID");

            migrationBuilder.RenameColumn(
                name: "PowerId",
                table: "TBL_POST",
                newName: "POWER_ID");

            migrationBuilder.RenameColumn(
                name: "Details_Id",
                table: "TBL_POST",
                newName: "DETAIL_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_YearId",
                table: "TBL_POST",
                newName: "IX_TBL_POST_YEAR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_UserId",
                table: "TBL_POST",
                newName: "IX_TBL_POST_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_POST_PowerId",
                table: "TBL_POST",
                newName: "IX_TBL_POST_POWER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_POWER_POWER_ID",
                table: "TBL_POST",
                column: "POWER_ID",
                principalTable: "TBL_POWER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_USERS_USER_ID",
                table: "TBL_POST",
                column: "USER_ID",
                principalTable: "TBL_USERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_YEAR_YEAR_ID",
                table: "TBL_POST",
                column: "YEAR_ID",
                principalTable: "TBL_YEAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
