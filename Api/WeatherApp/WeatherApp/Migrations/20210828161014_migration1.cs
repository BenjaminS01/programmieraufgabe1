using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApp.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "weather",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", nullable: true),
                    icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    main = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weather", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "place",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", nullable: true),
                    weatherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_place", x => x.id);
                    table.ForeignKey(
                        name: "FK_place_weather_weatherId",
                        column: x => x.weatherId,
                        principalTable: "weather",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "coord",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lat = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    lon = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    placeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coord", x => x.id);
                    table.ForeignKey(
                        name: "FK_coord_place_placeId",
                        column: x => x.placeId,
                        principalTable: "place",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "weather",
                columns: new[] { "id", "description", "icon", "main" },
                values: new object[,]
                {
                    { 1, "bewölkt", "https://img.icons8.com/small/16/000000/cloud.png", "Clouds" },
                    { 2, "teilweise bewölkt", "https://img.icons8.com/small/16/000000/partly-cloudy-day.png", "Clouds" },
                    { 3, "schnee", "https://img.icons8.com/small/16/000000/snow.png", "schnee" },
                    { 4, "sonnig", "https://img.icons8.com/small/16/000000/sun.png", "sonnig" }
                });

            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "id", "name", "weatherId" },
                values: new object[,]
                {
                    { 2, "Essen", 1 },
                    { 7, "New York", 1 },
                    { 10, "irgendwo", 1 },
                    { 1, "Erfurt", 2 },
                    { 3, "Eisenach", 2 },
                    { 9, "noch ein Ort", 2 },
                    { 4, "Stotternheim", 3 },
                    { 8, "Ort", 3 },
                    { 5, "Ibiza", 4 },
                    { 6, "Hanoi", 4 }
                });

            migrationBuilder.InsertData(
                table: "coord",
                columns: new[] { "id", "lat", "lon", "placeId" },
                values: new object[,]
                {
                    { 2, 210.1m, 10.2m, 2 },
                    { 4, 102.1m, 102.2m, 4 },
                    { 9, 11.1m, 11.2m, 9 },
                    { 3, 102.1m, 10.22m, 3 },
                    { 5, 110.1m, 110.2m, 5 },
                    { 1, 101.1m, 104.2m, 1 },
                    { 8, 12.1m, 10.2m, 8 },
                    { 7, 10.1m, 14.2m, 7 },
                    { 6, 10.12m, 141.2m, 6 },
                    { 10, 10.1m, 10.2m, 10 }
                });

            migrationBuilder.InsertData(
                table: "main",
                columns: new[] { "id", "feels_like", "humidity", "placeId", "pressure", "temp", "temp_max", "temp_min" },
                values: new object[,]
                {
                    { 10, 0m, 55, 10, 101, 22.22m, 232.11m, 20m },
                    { 5, 0m, 55, 5, 101, 21.22m, 32.11m, 20m },
                    { 8, 0m, 55, 8, 101, 22.22m, 34.11m, 2m },
                    { 7, 0m, 55, 7, 1, 2m, 232.11m, 20m },
                    { 3, 0m, 55, 3, 1, 2.22m, 132.11m, 20m },
                    { 6, 0m, 51, 6, 23, 22.22m, 232.11m, 22m },
                    { 9, 0m, 77, 9, 10, 22.22m, 232.11m, 20m },
                    { 2, 0m, 55, 2, 101, 22.22m, 232.11m, 20m },
                    { 4, 0m, 55, 4, 11, 22.23m, 232.11m, 20.1m },
                    { 1, 0m, 55, 1, 101, 22.22m, 23.1m, 20m }
                });

            migrationBuilder.InsertData(
                table: "wind",
                columns: new[] { "id", "deg", "placeId", "speed" },
                values: new object[,]
                {
                    { 5, 63, 5, 111m },
                    { 8, 43, 8, 31m },
                    { 3, 23, 3, 121m },
                    { 9, 4, 9, 131m },
                    { 1, 1, 1, 10m },
                    { 10, 3, 10, 31m },
                    { 7, 89, 7, 2m },
                    { 2, 11, 2, 101m },
                    { 4, 43, 4, 131m },
                    { 6, 73, 6, 11m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_coord_placeId",
                table: "coord",
                column: "placeId");

            migrationBuilder.CreateIndex(
                name: "IX_main_placeId",
                table: "main",
                column: "placeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_place_weatherId",
                table: "place",
                column: "weatherId");

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
                name: "wind");

            migrationBuilder.DropTable(
                name: "place");

            migrationBuilder.DropTable(
                name: "weather");
        }
    }
}
