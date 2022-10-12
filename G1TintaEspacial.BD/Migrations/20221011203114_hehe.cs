using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G1TintaEspacial.BD.Migrations
{
    public partial class hehe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "MedioPagoId_UQ",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "MedioPagoId_UQ",
                table: "Usuarios",
                column: "Id",
                unique: true);
        }
    }
}
