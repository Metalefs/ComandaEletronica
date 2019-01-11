using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class IDCHANGE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copa_Menu_IdMenu1",
                table: "Copa");

            migrationBuilder.DropForeignKey(
                name: "FK_Copa_Pedido_IdPedido1",
                table: "Copa");

            migrationBuilder.DropForeignKey(
                name: "FK_Cozinha_Menu_IdMenu1",
                table: "Cozinha");

            migrationBuilder.DropForeignKey(
                name: "FK_Cozinha_Pedido_IdPedido1",
                table: "Cozinha");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario1",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoIdMenu",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Mesa_MesaDoPedidoIdMesa",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdFuncionario1",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ItensDoPedidoIdMenu",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_MesaDoPedidoIdMesa",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Cozinha_IdMenu1",
                table: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Cozinha_IdPedido1",
                table: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Copa_IdMenu1",
                table: "Copa");

            migrationBuilder.DropIndex(
                name: "IX_Copa_IdPedido1",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "IdFuncionario1",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ItensDoPedidoIdMenu",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "MesaDoPedidoIdMesa",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdMenu1",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdPedido1",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdMenu1",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "IdPedido1",
                table: "Copa");

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMesa",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Funcionario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                table: "Cozinha",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Cozinha",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu",
                table: "Copa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Copa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdFuncionario",
                table: "Pedido",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdMenu",
                table: "Pedido",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdMesa",
                table: "Pedido",
                column: "IdMesa");

            migrationBuilder.CreateIndex(
                name: "IX_Cozinha_IdMenu",
                table: "Cozinha",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Cozinha_IdPedido",
                table: "Cozinha",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Copa_IdMenu",
                table: "Copa",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Copa_IdPedido",
                table: "Copa",
                column: "IdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Copa_Menu_IdMenu",
                table: "Copa",
                column: "IdMenu",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Copa_Pedido_IdPedido",
                table: "Copa",
                column: "IdPedido",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cozinha_Menu_IdMenu",
                table: "Cozinha",
                column: "IdMenu",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cozinha_Pedido_IdPedido",
                table: "Cozinha",
                column: "IdPedido",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario",
                table: "Pedido",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Menu_IdMenu",
                table: "Pedido",
                column: "IdMenu",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Mesa_IdMesa",
                table: "Pedido",
                column: "IdMesa",
                principalTable: "Mesa",
                principalColumn: "IdMesa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copa_Menu_IdMenu",
                table: "Copa");

            migrationBuilder.DropForeignKey(
                name: "FK_Copa_Pedido_IdPedido",
                table: "Copa");

            migrationBuilder.DropForeignKey(
                name: "FK_Cozinha_Menu_IdMenu",
                table: "Cozinha");

            migrationBuilder.DropForeignKey(
                name: "FK_Cozinha_Pedido_IdPedido",
                table: "Cozinha");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Menu_IdMenu",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Mesa_IdMesa",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdFuncionario",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdMenu",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdMesa",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Cozinha_IdMenu",
                table: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Cozinha_IdPedido",
                table: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Copa_IdMenu",
                table: "Copa");

            migrationBuilder.DropIndex(
                name: "IX_Copa_IdPedido",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdMesa",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdMenu",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Copa");

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario1",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItensDoPedidoIdMenu",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MesaDoPedidoIdMesa",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu1",
                table: "Cozinha",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido1",
                table: "Cozinha",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMenu1",
                table: "Copa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido1",
                table: "Copa",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdFuncionario1",
                table: "Pedido",
                column: "IdFuncionario1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ItensDoPedidoIdMenu",
                table: "Pedido",
                column: "ItensDoPedidoIdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_MesaDoPedidoIdMesa",
                table: "Pedido",
                column: "MesaDoPedidoIdMesa");

            migrationBuilder.CreateIndex(
                name: "IX_Cozinha_IdMenu1",
                table: "Cozinha",
                column: "IdMenu1");

            migrationBuilder.CreateIndex(
                name: "IX_Cozinha_IdPedido1",
                table: "Cozinha",
                column: "IdPedido1");

            migrationBuilder.CreateIndex(
                name: "IX_Copa_IdMenu1",
                table: "Copa",
                column: "IdMenu1");

            migrationBuilder.CreateIndex(
                name: "IX_Copa_IdPedido1",
                table: "Copa",
                column: "IdPedido1");

            migrationBuilder.AddForeignKey(
                name: "FK_Copa_Menu_IdMenu1",
                table: "Copa",
                column: "IdMenu1",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Copa_Pedido_IdPedido1",
                table: "Copa",
                column: "IdPedido1",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cozinha_Menu_IdMenu1",
                table: "Cozinha",
                column: "IdMenu1",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cozinha_Pedido_IdPedido1",
                table: "Cozinha",
                column: "IdPedido1",
                principalTable: "Pedido",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario1",
                table: "Pedido",
                column: "IdFuncionario1",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Menu_ItensDoPedidoIdMenu",
                table: "Pedido",
                column: "ItensDoPedidoIdMenu",
                principalTable: "Menu",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Mesa_MesaDoPedidoIdMesa",
                table: "Pedido",
                column: "MesaDoPedidoIdMesa",
                principalTable: "Mesa",
                principalColumn: "IdMesa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
