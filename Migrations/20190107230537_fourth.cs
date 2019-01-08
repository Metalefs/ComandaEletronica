using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItensCopa",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItensCozinha",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroDaMesa",
                table: "Mesa",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Mesa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItensCopa",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ItensCozinha",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Mesa");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDaMesa",
                table: "Mesa",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
