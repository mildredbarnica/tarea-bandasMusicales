using Microsoft.EntityFrameworkCore.Migrations;

namespace tareaBandas.Data.Migrations
{
    public partial class AddBandasModificado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Bandas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Bandas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
