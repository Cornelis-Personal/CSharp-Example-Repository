using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cornelis.Examples.DataAccess.Migrations
{
    public partial class Initial_Commit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalPlantHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rfid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPlantHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Rfid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BodyNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KillDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ossification = table.Column<int>(type: "int", nullable: false),
                    HumpHeight = table.Column<int>(type: "int", nullable: false),
                    RibFat = table.Column<int>(type: "int", nullable: false),
                    MeatColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatColour = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalPlantHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Rfid);
                    table.ForeignKey(
                        name: "FK_Animal_AnimalPlantHistory_AnimalPlantHistoryId",
                        column: x => x.AnimalPlantHistoryId,
                        principalTable: "AnimalPlantHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalPlantHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plant_AnimalPlantHistory_AnimalPlantHistoryId",
                        column: x => x.AnimalPlantHistoryId,
                        principalTable: "AnimalPlantHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_AnimalPlantHistoryId",
                table: "Animal",
                column: "AnimalPlantHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Plant_AnimalPlantHistoryId",
                table: "Plant",
                column: "AnimalPlantHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Plant");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AnimalPlantHistory");
        }
    }
}
