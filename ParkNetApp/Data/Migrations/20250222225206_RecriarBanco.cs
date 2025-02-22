using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkNetApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RecriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilizadorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AvencaId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_AspNetUsers_UtilizadorId",
                        column: x => x.UtilizadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Avencas_AvencaId",
                        column: x => x.AvencaId,
                        principalTable: "Avencas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_AvencaId",
                table: "Pagamentos",
                column: "AvencaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_UtilizadorId",
                table: "Pagamentos",
                column: "UtilizadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamentos");
        }
    }
}
