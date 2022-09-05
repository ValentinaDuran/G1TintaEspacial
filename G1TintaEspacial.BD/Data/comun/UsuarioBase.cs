using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TintaEspacial.BD.data.comun
{
    [Index(
    nameof(Id),
    Name = "UsuarioId",
    IsUnique = true)]
    public class UsuarioBase

    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Sexo es obligatorio.")]
        //[MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "El Dni es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Dni { get; set; }

        /*[Required(ErrorMessage = "La Fecha de Nacimiento es obligatoria.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int FechaNac { get; set; }//ESTÁ EN ENTITYBASE*/

        [Required(ErrorMessage = "El Email es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Nombre de Usuario es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Contraseña { get; set; }//ESTÁ EN ENTITYBASE

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Apellido { get; set; }//ESTÁ EN ENTITYBASE

        [Required(ErrorMessage = "La descripcion es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Imagen de perfil es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string ImagePerfil { get; set; }

        [Required(ErrorMessage = "La galeria es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Galeria { get; set; }//TODOS TIENEN GALERIA?

    }
}
