using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkNetApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustarPrecisaoSaldo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartaDeConducao",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartaDeCredito",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Saldo",
                table: "AspNetUsers",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidadeCrtCredito",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartaDeConducao",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CartaDeCredito",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ValidadeCrtCredito",
                table: "AspNetUsers");
        }
    }
}
