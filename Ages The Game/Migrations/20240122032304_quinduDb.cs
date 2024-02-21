using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ages_The_Game.Migrations
{
    /// <inheritdoc />
    public partial class quinduDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DadosImagem",
                table: "ItensDaLista");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "DadosImagem",
                table: "ItensDaLista",
                type: "longblob",
                nullable: true);
        }
    }
}
