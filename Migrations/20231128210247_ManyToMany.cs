using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Modul2WebTest28.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FlatPerson",
                columns: table => new
                {
                    FlatsId = table.Column<int>(type: "int", nullable: false),
                    PersonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatPerson", x => new { x.FlatsId, x.PersonsId });
                    table.ForeignKey(
                        name: "FK_FlatPerson_Flats_FlatsId",
                        column: x => x.FlatsId,
                        principalTable: "Flats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlatPerson_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FlatPerson_PersonsId",
                table: "FlatPerson",
                column: "PersonsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlatPerson");

            migrationBuilder.DropTable(
                name: "Flats");
        }
    }
}
