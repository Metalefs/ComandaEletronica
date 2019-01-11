using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ia_ComandaRestaurante.Migrations
{
    public partial class secondCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cozinha",
                table: "Cozinha");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Copa",
                table: "Copa");

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "Cozinha",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdCozinha",
                table: "Cozinha",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "Copa",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdCopa",
                table: "Copa",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cozinha",
                table: "Cozinha",
                column: "IdCozinha");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Copa",
                table: "Copa",
                column: "IdCopa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cozinha",
                table: "Cozinha");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Copa",
                table: "Copa");

            migrationBuilder.DropColumn(
                name: "IdCozinha",
                table: "Cozinha");

            migrationBuilder.DropColumn(
                name: "IdCopa",
                table: "Copa");

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "Cozinha",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "IdPedido",
                table: "Copa",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cozinha",
                table: "Cozinha",
                column: "IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Copa",
                table: "Copa",
                column: "IdPedido");
        }
    }
}
