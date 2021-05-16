using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBlazro.Migrations
{
    public partial class suppl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Supplements",
                columns: new[] { "Id", "Description", "Price", "RoomId", "Selected" },
                values: new object[] { 1, "Koffie Machine", 10, null, false });

            migrationBuilder.InsertData(
                table: "Supplements",
                columns: new[] { "Id", "Description", "Price", "RoomId", "Selected" },
                values: new object[] { 2, "WAS Machine", 10, null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Supplements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplements",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
