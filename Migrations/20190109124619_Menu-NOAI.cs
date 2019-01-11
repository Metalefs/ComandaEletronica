using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class MenuNOAI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioIdFuncionario",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_FuncionarioIdFuncionario",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "FuncionarioIdFuncionario",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_IdFuncionario",
                table: "Pedido",
                column: "IdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario",
                table: "Pedido",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_IdFuncionario",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_IdFuncionario",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioIdFuncionario",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_FuncionarioIdFuncionario",
                table: "Pedido",
                column: "FuncionarioIdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioIdFuncionario",
                table: "Pedido",
                column: "FuncionarioIdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
