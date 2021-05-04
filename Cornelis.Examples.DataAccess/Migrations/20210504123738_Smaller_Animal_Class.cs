using Microsoft.EntityFrameworkCore.Migrations;

namespace Cornelis.Examples.DataAccess.Migrations
{
    public partial class Smaller_Animal_Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatColour",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "MeatColour",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "RibFat",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Animal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FatColour",
                table: "Animal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MeatColour",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RibFat",
                table: "Animal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
