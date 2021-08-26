using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApp.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Erfurt" },
                    { 2, "Essen" },
                    { 3, "Eisenach" },
                    { 4, "Stotternheim" },
                    { 5, "Ibiza" },
                    { 6, "Hanoi" },
                    { 7, "New York" },
                    { 8, "Ort" },
                    { 9, "noch ein Ort" },
                    { 10, "irgendwo" }
                });

            migrationBuilder.InsertData(
                table: "coord",
                columns: new[] { "id", "Placeid", "lat", "lon" },
                values: new object[,]
                {
                    { 1, 1, 101.1m, 104.2m },
                    { 8, 8, 12.1m, 10.2m },
                    { 2, 2, 210.1m, 10.2m },
                    { 5, 5, 110.1m, 110.2m },
                    { 9, 9, 11.1m, 11.2m },
                    { 10, 10, 10.1m, 10.2m },
                    { 3, 3, 102.1m, 10.22m },
                    { 6, 6, 10.12m, 141.2m },
                    { 7, 7, 10.1m, 14.2m },
                    { 4, 4, 102.1m, 102.2m }
                });

            migrationBuilder.InsertData(
                table: "main",
                columns: new[] { "id", "feels_like", "humidity", "placeId", "pressure", "temp", "temp_max", "temp_min" },
                values: new object[,]
                {
                    { 9, 0m, 77, 9, 10, 22.22m, 232.11m, 20m },
                    { 5, 0m, 55, 5, 101, 21.22m, 32.11m, 20m },
                    { 8, 0m, 55, 8, 101, 22.22m, 34.11m, 2m },
                    { 6, 0m, 51, 6, 23, 22.22m, 232.11m, 22m },
                    { 7, 0m, 55, 7, 1, 2m, 232.11m, 20m },
                    { 3, 0m, 55, 3, 1, 2.22m, 132.11m, 20m },
                    { 2, 0m, 55, 2, 101, 22.22m, 232.11m, 20m },
                    { 10, 0m, 55, 10, 101, 22.22m, 232.11m, 20m },
                    { 1, 0m, 55, 1, 101, 22.22m, 23.1m, 20m },
                    { 4, 0m, 55, 4, 11, 22.23m, 232.11m, 20.1m }
                });

            migrationBuilder.InsertData(
                table: "weather",
                columns: new[] { "id", "Placeid", "description", "icon", "main" },
                values: new object[,]
                {
                    { 6, 6, "broken clouds", "01", "Clouds" },
                    { 7, 7, "broken clouds", "04", "Rain" },
                    { 9, 9, "broken clouds", "02", "Clouds" },
                    { 5, 5, "broken clouds", "02", "Rain" },
                    { 4, 4, "broken clouds", "03", "Snow" },
                    { 3, 3, "broken clouds", "02", "Clouds" },
                    { 2, 2, "broken clouds", "01", "Clouds" },
                    { 1, 1, "broken clouds", "02", "Snow" },
                    { 10, 10, "broken clouds", "01", "Clouds" },
                    { 8, 8, "broken clouds", "03", "Sun" }
                });

            migrationBuilder.InsertData(
                table: "wind",
                columns: new[] { "id", "deg", "placeId", "speed" },
                values: new object[,]
                {
                    { 9, 4, 9, 131m },
                    { 5, 63, 5, 111m },
                    { 7, 89, 7, 2m },
                    { 6, 73, 6, 11m },
                    { 4, 43, 4, 131m },
                    { 3, 23, 3, 121m },
                    { 2, 11, 2, 101m },
                    { 1, 1, 1, 10m },
                    { 8, 43, 8, 31m },
                    { 10, 3, 10, 31m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "coord",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "main",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "weather",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "wind",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
