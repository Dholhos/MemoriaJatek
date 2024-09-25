using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_791 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partok",
                columns: table => new
                {
                    rovidNev = table.Column<string>(type: "TEXT", nullable: false),
                    hosszudNev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partok", x => x.rovidNev);
                });

            migrationBuilder.CreateTable(
                name: "Jelolt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    Kerulet = table.Column<int>(type: "INTEGER", nullable: false),
                    SzavazatokSzama = table.Column<int>(type: "INTEGER", nullable: false),
                    PartrovidNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jelolt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jelolt_Partok_PartrovidNev",
                        column: x => x.PartrovidNev,
                        principalTable: "Partok",
                        principalColumn: "rovidNev",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jelolt_PartrovidNev",
                table: "Jelolt",
                column: "PartrovidNev");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jelolt");

            migrationBuilder.DropTable(
                name: "Partok");
        }
    }
}
