using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDeCulto.Migrations
{
    public partial class createBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Culto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PalavraInicial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinosHarpa = table.Column<int>(type: "int", nullable: false),
                    OracaoOportunidades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oportunidades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LouvorOfertas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OracaoOfertas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OracaoPreleitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preleitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adultos = table.Column<int>(type: "int", nullable: false),
                    Criancas = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Avisos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OracaoFinal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BencaoApostolica = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Culto");
        }
    }
}
