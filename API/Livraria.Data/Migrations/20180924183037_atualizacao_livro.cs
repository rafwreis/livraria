using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Data.Migrations
{
    public partial class atualizacao_livro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Livro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EditoraId",
                table: "Livro",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Versao = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Versao = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editora", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_AutorId",
                table: "Livro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro",
                column: "EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro",
                column: "EditoraId",
                principalTable: "Editora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autor_AutorId",
                table: "Livro");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Editora_EditoraId",
                table: "Livro");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Editora");

            migrationBuilder.DropIndex(
                name: "IX_Livro_AutorId",
                table: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Livro_EditoraId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "EditoraId",
                table: "Livro");
        }
    }
}
