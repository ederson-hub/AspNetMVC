using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMVC.Migrations
{
    public partial class produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Produtos_Produtoid",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Produtoid",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Produtoid",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "Produtoid",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_Produtoid",
                table: "Categorias",
                column: "Produtoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Produtos_Produtoid",
                table: "Categorias",
                column: "Produtoid",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Produtos_Produtoid",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_Produtoid",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Produtoid",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "Produtoid",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Produtoid",
                table: "Produtos",
                column: "Produtoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Produtos_Produtoid",
                table: "Produtos",
                column: "Produtoid",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
