using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class Redundance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Complexidade",
                table: "Pedido",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complexidade",
                table: "Pedido");
        }
    }
}
