using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio_MVC.Migrations
{
    public partial class AdicionandoAlocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncionarioTecnologiaId",
                table: "Alocacoes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alocacoes_FuncionarioTecnologiaId",
                table: "Alocacoes",
                column: "FuncionarioTecnologiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alocacoes_FuncionarioTecnologias_FuncionarioTecnologiaId",
                table: "Alocacoes",
                column: "FuncionarioTecnologiaId",
                principalTable: "FuncionarioTecnologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alocacoes_FuncionarioTecnologias_FuncionarioTecnologiaId",
                table: "Alocacoes");

            migrationBuilder.DropIndex(
                name: "IX_Alocacoes_FuncionarioTecnologiaId",
                table: "Alocacoes");

            migrationBuilder.DropColumn(
                name: "FuncionarioTecnologiaId",
                table: "Alocacoes");
        }
    }
}
