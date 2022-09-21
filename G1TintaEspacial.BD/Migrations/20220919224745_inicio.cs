using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G1TintaEspacial.BD.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    IdNombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedioPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    FotoCarne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estilos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageCarnetSanitario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CarnSanitario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Habilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    IdNFT = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Compra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estiloss = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageCarnetSanitarioo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phonee = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
