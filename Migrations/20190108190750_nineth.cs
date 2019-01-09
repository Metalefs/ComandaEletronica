using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioResponsavelIdFuncionario",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "FuncionarioResponsavelIdFuncionario",
                table: "Pedido",
                newName: "FuncionarioIdFuncionario");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_FuncionarioResponsavelIdFuncionario",
                table: "Pedido",
                newName: "IX_Pedido_FuncionarioIdFuncionario");

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioResponsavel",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioIdFuncionario",
                table: "Pedido",
                column: "FuncionarioIdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioIdFuncionario",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "FuncionarioResponsavel",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "FuncionarioIdFuncionario",
                table: "Pedido",
                newName: "FuncionarioResponsavelIdFuncionario");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_FuncionarioIdFuncionario",
                table: "Pedido",
                newName: "IX_Pedido_FuncionarioResponsavelIdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Funcionario_FuncionarioResponsavelIdFuncionario",
                table: "Pedido",
                column: "FuncionarioResponsavelIdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
