using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module7_data_transfer.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: "Youth-olympics");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[] { "youth-olympics", "Youth Olympic Games" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameID",
                keyValue: "youth-olympics");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[] { "Youth-olympics", "Youth Olympic Games" });
        }
    }
}
