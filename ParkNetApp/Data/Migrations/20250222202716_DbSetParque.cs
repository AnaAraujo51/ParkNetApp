using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkNetApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbSetParque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Edificio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pisos = table.Column<int>(type: "int", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parques", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parques");
        }
    }
}
