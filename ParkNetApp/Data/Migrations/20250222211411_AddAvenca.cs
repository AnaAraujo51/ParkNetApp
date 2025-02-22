using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkNetApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAvenca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avencas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParqueId = table.Column<int>(type: "int", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilizadorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avencas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avencas_AspNetUsers_UtilizadorId",
                        column: x => x.UtilizadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avencas_Parques_ParqueId",
                        column: x => x.ParqueId,
                        principalTable: "Parques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avencas_ParqueId",
                table: "Avencas",
                column: "ParqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Avencas_UtilizadorId",
                table: "Avencas",
                column: "UtilizadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avencas");
        }
    }
}
