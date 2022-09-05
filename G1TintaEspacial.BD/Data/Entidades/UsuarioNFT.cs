using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TintaEspacial.BD.data.comun;
using TINTAESPACIAL.DataBase.Entidades;

namespace TINTAESPACIAL.DataBase.data.Entidades
{
    public class UsuarioNFT :UsuarioBase //: UsuarioArtista
    {
        [Required(ErrorMessage = "Campo obligatorio.")]
        public string TokenId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]

        public string NombreObra { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        
        public string DescripcionObra { get; set; }//cambie el nombre wey,sino me confundía con la otra descripcion

        [Required]
        public string Compra { get; set; }

        [Required(ErrorMessage = "El phone es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Telefono { get; set; }
    }
}
