using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forsaj.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOGIN_LOG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Error = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IP = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Browser = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Success = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGIN_LOG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_BAN_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_BAN_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CARS_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DISKI = table.Column<bool>(type: "bit", nullable: false),
                    QAPANMA = table.Column<bool>(type: "bit", nullable: false),
                    DERI_SALON = table.Column<bool>(type: "bit", nullable: false),
                    ABS = table.Column<bool>(type: "bit", nullable: false),
                    PARK_RADAR = table.Column<bool>(type: "bit", nullable: false),
                    KSENON_LAMPALAR = table.Column<bool>(type: "bit", nullable: false),
                    LYUK = table.Column<bool>(type: "bit", nullable: false),
                    KONDISIONER = table.Column<bool>(type: "bit", nullable: false),
                    KAMERA = table.Column<bool>(type: "bit", nullable: false),
                    SENSOR = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CARS_DETAILS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CITY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CITY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_COLOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_COLOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_COMPANY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_COMPANY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_COUNTRY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_COUNTRY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CURRENCY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MONEY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CURRENCY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_FUEL_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_FUEL_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_IMAGE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TYPE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_IMAGE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_MARKA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MARKA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_POWER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAPACITY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_POWER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ROLE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SPEED_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SPEED_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TELEFON",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMBER = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TELEFON", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TRANSMISSION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TRANSMISSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    COMPANY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_USERS_TBL_COMPANY_COMPANY_ID",
                        column: x => x.COMPANY_ID,
                        principalTable: "TBL_COMPANY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_MODEL_CARS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MARKA_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MODEL_CARS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_MODEL_CARS_TBL_MARKA_MARKA_ID",
                        column: x => x.MARKA_ID,
                        principalTable: "TBL_MARKA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER_AND_ROLE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    ROLE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_AND_ROLE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USER_AND_ROLE_TBL_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "TBL_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_AND_ROLE_TBL_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TBL_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_AND_TELEFON",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    TELEFON_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_AND_TELEFON", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USER_AND_TELEFON_TBL_TELEFON_TELEFON_ID",
                        column: x => x.TELEFON_ID,
                        principalTable: "TBL_TELEFON",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_AND_TELEFON_TBL_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TBL_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_MODEL_CARS_MARKA_ID",
                table: "TBL_MODEL_CARS",
                column: "MARKA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USERS_COMPANY_ID",
                table: "TBL_USERS",
                column: "COMPANY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_AND_ROLE_ROLE_ID",
                table: "USER_AND_ROLE",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_AND_ROLE_USER_ID",
                table: "USER_AND_ROLE",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_AND_TELEFON_TELEFON_ID",
                table: "USER_AND_TELEFON",
                column: "TELEFON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_AND_TELEFON_USER_ID",
                table: "USER_AND_TELEFON",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOGIN_LOG");

            migrationBuilder.DropTable(
                name: "TBL_BAN_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_CARS_DETAILS");

            migrationBuilder.DropTable(
                name: "TBL_CITY");

            migrationBuilder.DropTable(
                name: "TBL_COLOR");

            migrationBuilder.DropTable(
                name: "TBL_COUNTRY");

            migrationBuilder.DropTable(
                name: "TBL_CURRENCY");

            migrationBuilder.DropTable(
                name: "TBL_FUEL_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_IMAGE");

            migrationBuilder.DropTable(
                name: "TBL_MODEL_CARS");

            migrationBuilder.DropTable(
                name: "TBL_POWER");

            migrationBuilder.DropTable(
                name: "TBL_SPEED_TYPE");

            migrationBuilder.DropTable(
                name: "TBL_TRANSMISSION");

            migrationBuilder.DropTable(
                name: "USER_AND_ROLE");

            migrationBuilder.DropTable(
                name: "USER_AND_TELEFON");

            migrationBuilder.DropTable(
                name: "TBL_MARKA");

            migrationBuilder.DropTable(
                name: "TBL_ROLE");

            migrationBuilder.DropTable(
                name: "TBL_TELEFON");

            migrationBuilder.DropTable(
                name: "TBL_USERS");

            migrationBuilder.DropTable(
                name: "TBL_COMPANY");
        }
    }
}
