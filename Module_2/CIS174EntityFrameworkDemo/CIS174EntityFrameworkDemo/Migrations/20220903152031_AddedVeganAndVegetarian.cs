using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIS174EntityFrameworkDemo.Migrations
{
    public partial class AddedVeganAndVegetarian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isVegan",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isVegetarian",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isVegan",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "isVegetarian",
                table: "Recipes");
        }
    }
}
