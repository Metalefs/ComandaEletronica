using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class _2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDoFuncionario = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    SenhaDeAcesso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Mesa",
                columns: table => new
                {
                    IdMesa = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDoCliente = table.Column<string>(nullable: true),
                    NumeroDaMesa = table.Column<string>(nullable: true),
                    QuantidadeDePessoas = table.Column<int>(nullable: false),
                    disponivel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesa", x => x.IdMesa);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrazoDoPedido = table.Column<int>(nullable: false),
                    MesaDoPedidoIdMesa = table.Column<int>(nullable: true),
                    FuncionarioResponsavelIdFuncionario = table.Column<int>(nullable: true),
                    PrecoDoPedido = table.Column<float>(nullable: false),
                    ItensDoPedidoId = table.Column<int>(nullable: true),
                    Completo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Funcionario_FuncionarioResponsavelIdFuncionario",
                        column: x => x.FuncionarioResponsavelIdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Menu_ItensDoPedidoId",
                        column: x => x.ItensDoPedidoId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Mesa_MesaDoPedidoIdMesa",
                        column: x => x.MesaDoPedidoIdMesa,
                        principalTable: "Mesa",
                        principalColumn: "IdMesa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_FuncionarioResponsavelIdFuncionario",
                table: "Pedido",
                column: "FuncionarioResponsavelIdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ItensDoPedidoId",
                table: "Pedido",
                column: "ItensDoPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_MesaDoPedidoIdMesa",
                table: "Pedido",
                column: "MesaDoPedidoIdMesa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Mesa");
        }
    }
}
