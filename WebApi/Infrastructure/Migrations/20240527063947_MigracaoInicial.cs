using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strength = table.Column<int>(type: "int", nullable: false),
                    dexterity = table.Column<int>(type: "int", nullable: false),
                    constitution = table.Column<int>(type: "int", nullable: false),
                    intelligence = table.Column<int>(type: "int", nullable: false),
                    wisdom = table.Column<int>(type: "int", nullable: false),
                    charisma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Knights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AttributesId = table.Column<int>(type: "int", nullable: false),
                    KeyAttribute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHero = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knights_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mod = table.Column<int>(type: "int", nullable: false),
                    Attr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipped = table.Column<bool>(type: "bit", nullable: false),
                    KnightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Knights_KnightId",
                        column: x => x.KnightId,
                        principalTable: "Knights",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knights_AttributesId",
                table: "Knights",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_KnightId",
                table: "Weapons",
                column: "KnightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Knights");

            migrationBuilder.DropTable(
                name: "Attributes");
        }
    }
}
