using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ages_The_Game.Migrations
{
    /// <inheritdoc />
    public partial class AgeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Continente",
                table: "ItensDaLista",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Continente",
                table: "ItensDaLista");
        }
    }
}
