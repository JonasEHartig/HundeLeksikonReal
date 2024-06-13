using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeLeksikon.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateHans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HundeData",
                columns: table => new
                {
                    HundeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HundeNavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FCIGrupper = table.Column<int>(type: "int", nullable: false),
                    HundeStørrelse = table.Column<int>(type: "int", nullable: false),
                    HundeTemperament = table.Column<int>(type: "int", nullable: false),
                    HundePelspleje = table.Column<int>(type: "int", nullable: false),
                    HundeEnergi = table.Column<int>(type: "int", nullable: false),
                    HundeBeskrivelsen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HundeData", x => x.HundeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HundeData");
        }
    }
}
