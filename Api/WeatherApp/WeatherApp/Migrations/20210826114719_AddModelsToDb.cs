using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApp.Migrations
{
    public partial class AddModelsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "place",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_place", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coord",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    lon = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    Placeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coord", x => x.id);
                    table.ForeignKey(
                        name: "FK_coord_place_Placeid",
                        column: x => x.Placeid,
                        principalTable: "place",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "main",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feels_like = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    humidity = table.Column<int>(type: "int", nullable: false),
                    pressure = table.Column<int>(type: "int", nullable: false),
                    temp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    temp_max = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    temp_min = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    placeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_main", x => x.id);
                    table.ForeignKey(
                        name: "FK_main_place_placeId",
                        column: x => x.placeId,
                        principalTable: "place",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weather",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", nullable: true),
                    icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    main = table.Column<string>(type: "varchar(100)", nullable: true),
                    Placeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weather", x => x.id);
                    table.ForeignKey(
                        name: "FK_weather_place_Placeid",
                        column: x => x.Placeid,
                        principalTable: "place",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wind",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deg = table.Column<int>(type: "int", nullable: false),
                    speed = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    placeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wind", x => x.id);
                    table.ForeignKey(
                        name: "FK_wind_place_placeId",
                        column: x => x.placeId,
                        principalTable: "place",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coord_Placeid",
                table: "coord",
                column: "Placeid");

            migrationBuilder.CreateIndex(
                name: "IX_main_placeId",
                table: "main",
                column: "placeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_weather_Placeid",
                table: "weather",
                column: "Placeid");

            migrationBuilder.CreateIndex(
                name: "IX_wind_placeId",
                table: "wind",
                column: "placeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coord");

            migrationBuilder.DropTable(
                name: "main");

            migrationBuilder.DropTable(
                name: "weather");

            migrationBuilder.DropTable(
                name: "wind");

            migrationBuilder.DropTable(
                name: "place");
        }
    }
}
