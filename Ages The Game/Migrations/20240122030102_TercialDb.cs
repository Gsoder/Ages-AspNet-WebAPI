using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ages_The_Game.Migrations
{
    /// <inheritdoc />
    public partial class TercialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagens",
                table: "ItensDaLista");

            migrationBuilder.AddColumn<string>(
                name: "Base64Imagem",
                table: "ItensDaLista",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<byte[]>(
                name: "DadosImagem",
                table: "ItensDaLista",
                type: "longblob",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64Imagem",
                table: "ItensDaLista");

            migrationBuilder.DropColumn(
                name: "DadosImagem",
                table: "ItensDaLista");

            migrationBuilder.AddColumn<string>(
                name: "Imagens",
                table: "ItensDaLista",
                type: "varchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
