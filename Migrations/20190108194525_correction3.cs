using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class correction3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomaItensCopa",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "SomaItensCozinha",
                table: "Pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SomaItensCopa",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SomaItensCozinha",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);
        }
    }
}
