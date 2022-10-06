using G1TintaEspacial.BD.Data.Entidades;
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

        [Required(ErrorMessage = "El Nombre de Usuario es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Contraseña { get; set; }

        [Required(ErrorMessage = "La Imagen de perfil es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string? ImagePerfil { get; set; }
        #endregion

        #region Tatuador
        public string MercadoPago { get; set; }

        [Required(ErrorMessage = "El phone es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Telefono { get; set; }
        public int MedioPagoId { get; set; }//id+propiedad siempre unidos y en ese orden id arriba y propiedad abajo
        public MedioPago MedioPago { get; set; }//propiedad de tipo medio de pag. relacion 1=1
        #endregion
        // nueva tabla con contacto? estudio-artista-tatuador
        // como hacer con lo que tienen en comun estos tres?
        //redes sosciales de estudio-artista
    }
}
