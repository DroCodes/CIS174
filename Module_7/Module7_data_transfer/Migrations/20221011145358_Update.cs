using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module7_data_transfer.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "uru",
                column: "FlagImage",
                value: "images/uraguay_flag.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "CountryID",
                keyValue: "uru",
                column: "FlagImage",
                value: "images/uruguay_flag.png");
        }
    }
}
