using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "Mesa");

            migrationBuilder.AlterColumn<string>(
                name: "PrazoDoPedido",
                table: "Pedido",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Disponibilidade",
                table: "Mesa",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibilidade",
                table: "Mesa");

            migrationBuilder.AlterColumn<int>(
                name: "PrazoDoPedido",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Disponivel",
                table: "Mesa",
                nullable: false,
                defaultValue: 0);
        }
    }
}
