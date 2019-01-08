using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItensCozinha",
                table: "Pedido",
                newName: "SomaItensCozinha");

            migrationBuilder.RenameColumn(
                name: "ItensCopa",
                table: "Pedido",
                newName: "SomaItensCopa");

            migrationBuilder.AddColumn<int>(
                name: "CopaidPedido",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CozinhaidPedido",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido1",
                table: "Menu",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido2",
                table: "Menu",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Copa",
                columns: table => new
                {
                    idPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copa", x => x.idPedido);
                });

            migrationBuilder.CreateTable(
                name: "Cozinha",
                columns: table => new
                {
                    idPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cozinha", x => x.idPedido);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CopaidPedido",
                table: "Pedido",
                column: "CopaidPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CozinhaidPedido",
                table: "Pedido",
                column: "CozinhaidPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido1",
                table: "Menu",
                column: "PedidoIdPedido1");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PedidoIdPedido2",
                table: "Menu",
                column: "PedidoIdPedido2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "Copa");

            migrationBuilder.DropTable(
                name: "Cozinha");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CopaidPedido",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CozinhaidPedido",
                table: "Pedido");

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
                name: "CozinhaidPedido",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido1",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido2",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "SomaItensCozinha",
                table: "Pedido",
                newName: "ItensCozinha");

            migrationBuilder.RenameColumn(
                name: "SomaItensCopa",
                table: "Pedido",
                newName: "ItensCopa");
        }
    }
}
