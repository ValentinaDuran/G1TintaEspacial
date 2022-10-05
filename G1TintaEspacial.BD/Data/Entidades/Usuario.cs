using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TintaEspacial.BD.data.comun;
//using TINTAESPACIAL.DataBase.Entidades;

namespace TINTAESPACIAL.DataBase.data.Entidades
{
    public class Usuario 
    {
        #region Usuario
        [Required]
        public int Id { get; set; }// idusuario

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Dni es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "El Nombre de Usuario es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string IdNombreUsuario { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Contraseña { get; set; }


        [Required(ErrorMessage = "La descripcion es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La Imagen de perfil es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string ImagePerfil { get; set; }//obligatoria o no? en el caso de no ser obligatoria poner una por defecto

        [Required(ErrorMessage = "La galeria es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Galeria { get; set; }

        #endregion

        #region Tatuador

        [Required(ErrorMessage = "Los estilos son obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Estiloss { get; set; }

        [Required(ErrorMessage = "La imagen de carnet sanitario obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string ImageCarnetSanitarioo { get; set; }// ESTUDIO Y TATUAADOR TIENEN CARNET SANITARIO

        [Required(ErrorMessage = "El phone es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public int Phonee { get; set; }
        #endregion
        // nueva tabla con contacto? estudio-artista-tatuador
        // como hacer con lo que tienen en comun estos tres?
        //redes sosciales de estudio-artista
    }
}
