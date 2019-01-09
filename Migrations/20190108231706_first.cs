using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido1",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido2",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Copa_CopaidPedido",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cozinha_CozinhaidPedido",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CopaidPedido",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Menu_PedidoIdPedido",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_PedidoIdPedido1",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_PedidoIdPedido2",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CopaidPedido",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido1",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido2",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "CozinhaidPedido",
                table: "Pedido",
                newName: "ItensDoPedidoIdMenu");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_CozinhaidPedido",
                table: "Pedido",
                newName: "IX_Pedido_ItensDoPedidoIdMenu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Menu",
                newName: "IdMenu");

            migrationBuilder.RenameColumn(
                name: "idPedido",
                table: "Cozinha",
                newName: "IdPedido");

            migrationBuilder.RenameColumn(
                name: "idPedido",
                table: "Copa",
                newName: "IdPedido");

            migrationBuilder.AddColumn<string>(
                name: "TipoDoPedido",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                table: "Cozinha",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Cozinha",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                table: "Copa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Copa",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoIdMenu",
                table: "Pedido",
                column: "ItensDoPedidoIdMenu",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoIdMenu",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "TipoDoPedido",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Copa");

            migrationBuilder.RenameColumn(
                name: "ItensDoPedidoIdMenu",
                table: "Pedido",
                newName: "CozinhaidPedido");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ItensDoPedidoIdMenu",
                table: "Pedido",
                newName: "IX_Pedido_CozinhaidPedido");

            migrationBuilder.RenameColumn(
                name: "IdMenu",
                table: "Menu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "Cozinha",
                newName: "idPedido");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "Copa",
                newName: "idPedido");

            migrationBuilder.AddColumn<int>(
                name: "CopaidPedido",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Menu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido1",
                table: "Menu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido2",
                table: "Menu",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CopaidPedido",
                table: "Pedido",
                column: "CopaidPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido",
                table: "Menu",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido1",
                table: "Menu",
                column: "PedidoIdPedido1");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido2",
                table: "Menu",
                column: "PedidoIdPedido2");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido",
                table: "Menu",
                column: "PedidoIdPedido",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido1",
                table: "Menu",
                column: "PedidoIdPedido1",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Pedido_PedidoIdPedido2",
                table: "Menu",
                column: "PedidoIdPedido2",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Copa_CopaidPedido",
                table: "Pedido",
                column: "CopaidPedido",
                principalTable: "Copa",
                principalColumn: "idPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cozinha_CozinhaidPedido",
                table: "Pedido",
                column: "CozinhaidPedido",
                principalTable: "Cozinha",
                principalColumn: "idPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
