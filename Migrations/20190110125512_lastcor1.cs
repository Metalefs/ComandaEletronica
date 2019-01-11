using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class lastcor1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Mesa_MesaDoPedidoIdMesa",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa");

            migrationBuilder.RenameColumn(
                name: "MesaDoPedidoIdMesa",
                table: "Pedido",
                newName: "MesaDoPedidoNumeroDaMesa");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_MesaDoPedidoIdMesa",
                table: "Pedido",
                newName: "IX_Pedido_MesaDoPedidoNumeroDaMesa");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroDaMesa",
                table: "Mesa",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa",
                column: "NumeroDaMesa");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Mesa_MesaDoPedidoNumeroDaMesa",
                table: "Pedido",
                column: "MesaDoPedidoNumeroDaMesa",
                principalTable: "Mesa",
                principalColumn: "NumeroDaMesa",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Mesa_MesaDoPedidoNumeroDaMesa",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa");

            migrationBuilder.RenameColumn(
                name: "MesaDoPedidoNumeroDaMesa",
                table: "Pedido",
                newName: "MesaDoPedidoIdMesa");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_MesaDoPedidoNumeroDaMesa",
                table: "Pedido",
                newName: "IX_Pedido_MesaDoPedidoIdMesa");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroDaMesa",
                table: "Mesa",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa",
                column: "IdMesa");

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
