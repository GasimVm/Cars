using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class ChangePostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POST_IMAGES");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATE_DATE",
                table: "TBL_POST",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "TBL_POST",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "TBL_POST",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATE_DATE",
                table: "TBL_IMAGE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "POST_ID",
                table: "TBL_IMAGE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_POST_ImageId",
                table: "TBL_POST",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_IMAGE_POST_ID",
                table: "TBL_IMAGE",
                column: "POST_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_IMAGE_TBL_POST_POST_ID",
                table: "TBL_IMAGE",
                column: "POST_ID",
                principalTable: "TBL_POST",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_POST_TBL_IMAGE_ImageId",
                table: "TBL_POST",
                column: "ImageId",
                principalTable: "TBL_IMAGE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_IMAGE_TBL_POST_POST_ID",
                table: "TBL_IMAGE");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_POST_TBL_IMAGE_ImageId",
                table: "TBL_POST");

            migrationBuilder.DropIndex(
                name: "IX_TBL_POST_ImageId",
                table: "TBL_POST");

            migrationBuilder.DropIndex(
                name: "IX_TBL_IMAGE_POST_ID",
                table: "TBL_IMAGE");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "TBL_POST");

            migrationBuilder.DropColumn(
                name: "CREATE_DATE",
                table: "TBL_IMAGE");

            migrationBuilder.DropColumn(
                name: "POST_ID",
                table: "TBL_IMAGE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATE_DATE",
                table: "TBL_POST",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.CreateTable(
                name: "POST_IMAGES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMAGE_ID = table.Column<int>(type: "int", nullable: false),
                    POST_ID = table.Column<int>(type: "int", nullable: false)
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
        }
    }
}
