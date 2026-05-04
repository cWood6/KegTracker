using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KegTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brewer = table.Column<string>(type: "TEXT", nullable: false),
                    ABV = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kegs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BeerId = table.Column<int>(type: "INTEGER", nullable: false),
                    CapacityLitres = table.Column<double>(type: "REAL", nullable: false),
                    RemainingLitres = table.Column<double>(type: "REAL", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kegs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kegs_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumptionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KegId = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountPouredLitres = table.Column<double>(type: "REAL", nullable: false),
                    PouredAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumptionLogs_Kegs_KegId",
                        column: x => x.KegId,
                        principalTable: "Kegs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionLogs_KegId",
                table: "ConsumptionLogs",
                column: "KegId");

            migrationBuilder.CreateIndex(
                name: "IX_Kegs_BeerId",
                table: "Kegs",
                column: "BeerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumptionLogs");

            migrationBuilder.DropTable(
                name: "Kegs");

            migrationBuilder.DropTable(
                name: "Beers");
        }
    }
}
