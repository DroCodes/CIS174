using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module7_data_transfer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countrys_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countrys_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "OutDoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "parlympics", "Winter Olympics" },
                    { "summer-olympics", "Summer Olympics" },
                    { "winter-olympics", "Winter Olympics" },
                    { "Youth-olympics", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameID", "Name" },
                values: new object[,]
                {
                    { "aus", "outdoor", "images/australian_flag.png", "parlympics", "Australia" },
                    { "bra", "outdoor", "images/brazillian_flag.png", "summer-olympics", "Brazil" },
                    { "can", "indoor", "images/canadian_flag.png", "winter-olympics", "Canada" },
                    { "chi", "indoor", "images/chinese_flag.png", "summer-olympics", "China" },
                    { "cyp", "indoor", "images/cyprus_flag.png", "youth-olympics", "Cyprus" },
                    { "fin", "outdoor", "images/finnish_flag.png", "youth-olympics", "Finland" },
                    { "fra", "indoor", "images/french_flag.png", "youth-olympics", "France" },
                    { "gb", "indoor", "images/british_flag.png", "winter-olympics", "Great Britain" },
                    { "ger", "indoor", "images/german_flag.png", "summer-olympics", "Germany" },
                    { "ita", "outdoor", "images/italian_flag.png", "winter-olympics", "Italy" },
                    { "jam", "outdoor", "images/jamaican_flag.png", "winter-olympics", "Jamaica" },
                    { "jap", "outdoor", "images/japanese_flag.png", "winter-olympics", "Japan" },
                    { "mex", "indoor", "images/mexican_flag.png", "summer-olympics", "Mexico" },
                    { "net", "outdoor", "images/netherlands_flag.png", "summer-olympics", "Netherlands" },
                    { "pak", "outdoor", "images/pakistan_flag.png", "parlympics", "Pakistan" },
                    { "por", "outdoor", "images/portugese_flag.png", "youth-olympics", "Portugal" },
                    { "rus", "indoor", "images/russian_flag.png", "youth-olympics", "Russia" },
                    { "slov", "outdoor", "images/slovakian_flag.png", "youth-olympics", "Slovakia" },
                    { "swe", "indoor", "images/swedish_flag.png", "winter-olympics", "Sweden" },
                    { "thai", "indoor", "images/thai_flag.png", "parlympics", "Thailand" },
                    { "ukr", "indoor", "images/ukrain_flag.png", "parlympics", "Ukrain" },
                    { "uru", "indoor", "images/uruguay_flag.png", "parlympics", "Uruguay" },
                    { "usa", "outdoor", "images/usa_flag.png", "summer-olympics", "USA" },
                    { "zim", "outdoor", "images/zimbabwe_flag.png", "parlympics", "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_CategoryID",
                table: "Countrys",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_GameID",
                table: "Countrys",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
