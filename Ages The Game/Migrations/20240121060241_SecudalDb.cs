﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ages_The_Game.Migrations
{
    /// <inheritdoc />
    public partial class SecudalDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dica1",
                table: "ItensDaLista",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dica2",
                table: "ItensDaLista",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dica3",
                table: "ItensDaLista",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dica1",
                table: "ItensDaLista");

            migrationBuilder.DropColumn(
                name: "Dica2",
                table: "ItensDaLista");

            migrationBuilder.DropColumn(
                name: "Dica3",
                table: "ItensDaLista");
        }
    }
}
