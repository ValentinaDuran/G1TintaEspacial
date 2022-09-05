using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TintaEspacial.BD.data.comun;
using TINTAESPACIAL.DataBase.data.Entidades;

namespace TINTAESPACIAL.DataBase.Entidades
{
    public class UsuarioTatuador : UsuarioBase

    {
        
        [Required(ErrorMessage = "Los estilos son obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Estilos { get; set; }

        [Required(ErrorMessage = "La imagen de carnet sanitario obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string ImageCarnetSanitario { get; set; }// ESTUDIO Y TATUAADOR TIENEN CARNET SANITARIO

        [Required(ErrorMessage = "El phone es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public int Phone { get; set; }
    }
}
