using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio_MVC.Migrations
{
    public partial class AddTecnologia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoTec",
                table: "Tecnologias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoTec",
                table: "Tecnologias");
        }
    }
}
