using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ItensDoPedidoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Completo",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ItensDoPedidoId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "disponivel",
                table: "Mesa",
                newName: "Disponivel");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Disponivel",
                table: "Mesa",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Menu",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido",
                table: "Menu",
                column: "PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido",
                table: "Menu",
                column: "PedidoIdPedido",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_PedidoIdPedido",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "Disponivel",
                table: "Mesa",
                newName: "disponivel");

            migrationBuilder.AddColumn<bool>(
                name: "Completo",
                table: "Pedido",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ItensDoPedidoId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "disponivel",
                table: "Mesa",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ItensDoPedidoId",
                table: "Pedido",
                column: "ItensDoPedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoId",
                table: "Pedido",
                column: "ItensDoPedidoId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
