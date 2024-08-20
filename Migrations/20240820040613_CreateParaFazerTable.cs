using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoGerenciarTarefas.Migrations
{
    /// <inheritdoc />
    public partial class CreateParaFazerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aFazeres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataLimite = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    DataFinalicao = table.Column<DateOnly>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aFazeres", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aFazeres");
        }
    }
}
