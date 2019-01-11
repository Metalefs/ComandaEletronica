using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class CopaCozinha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
