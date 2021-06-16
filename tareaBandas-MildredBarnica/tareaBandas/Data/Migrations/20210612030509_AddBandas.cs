using Microsoft.EntityFrameworkCore.Migrations;

namespace tareaBandas.Data.Migrations
{
    public partial class AddBandas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    BandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandaGenero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandaSitioWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    BandaInicio = table.Column<int>(type: "int", nullable: false),
                    BandaVocalista = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.BandaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bandas");
        }
    }
}
