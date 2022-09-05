using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G1TintaEspacial.BD.Migrations
{
    public partial class inicios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tatuadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estilos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageCarnetSanitario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatuadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEstudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarnSanitario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Habilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedioPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotCarne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estilos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageCarnetSanitario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEstudios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioNFTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Compra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioNFTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePerfil = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Galeria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "UsuarioId",
                table: "Artistas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsuarioId1",
                table: "Tatuadores",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsuarioId3",
                table: "UsuarioEstudios",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsuarioId4",
                table: "UsuarioNFTs",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsuarioId2",
                table: "Usuarios",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Tatuadores");

            migrationBuilder.DropTable(
                name: "UsuarioEstudios");

            migrationBuilder.DropTable(
                name: "UsuarioNFTs");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
