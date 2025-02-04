using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortariaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoPropEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Visitantes",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "Endereço",
                table: "Prestador",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Porteiro",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "Endereço",
                table: "Morador",
                newName: "Rua");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Visitantes",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Visitantes",
                type: "NVARCHAR(140)",
                maxLength: 140,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroCasa",
                table: "Registro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Registro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Prestador",
                type: "NVARCHAR(140)",
                maxLength: 140,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroCasa",
                table: "Porteiro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Morador",
                type: "NVARCHAR(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Visitantes");

            migrationBuilder.DropColumn(
                name: "NumeroCasa",
                table: "Registro");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Registro");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Prestador");

            migrationBuilder.DropColumn(
                name: "NumeroCasa",
                table: "Porteiro");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Morador");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Visitantes",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Prestador",
                newName: "Endereço");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Porteiro",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Morador",
                newName: "Endereço");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Visitantes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
