using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortariaAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Morador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Endereço = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RG = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Porteiro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DocumentoRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porteiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePrestador = table.Column<string>(name: "Nome Prestador", type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DocumentoRG = table.Column<string>(name: "Documento RG:", type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    Endereço = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DocumentoRG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Endereco = table.Column<string>(type: "NVARCHAR(140)", maxLength: 140, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitanteId = table.Column<int>(type: "int", nullable: false),
                    MoradorId = table.Column<int>(type: "int", nullable: false),
                    PrestadorServicoId = table.Column<int>(type: "int", nullable: false),
                    horarioEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horarioSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PorteiroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Registro_Morador_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "Morador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registro_Porteiro_PorteiroId",
                        column: x => x.PorteiroId,
                        principalTable: "Porteiro",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registro_Prestador_PrestadorServicoId",
                        column: x => x.PrestadorServicoId,
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registro_Visitantes_VisitanteId",
                        column: x => x.VisitanteId,
                        principalTable: "Visitantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registro_MoradorId",
                table: "Registro",
                column: "MoradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_PorteiroId",
                table: "Registro",
                column: "PorteiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_PrestadorServicoId",
                table: "Registro",
                column: "PrestadorServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_VisitanteId",
                table: "Registro",
                column: "VisitanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropTable(
                name: "Morador");

            migrationBuilder.DropTable(
                name: "Porteiro");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropTable(
                name: "Visitantes");
        }
    }
}
