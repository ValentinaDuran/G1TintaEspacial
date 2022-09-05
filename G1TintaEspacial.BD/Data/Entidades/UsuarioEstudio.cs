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
    public class UsuarioEstudio :UsuarioBase//: UsuarioTatuador

    {
        //estudio heredaria de tatuador
        //tatuador de usuario
        //artista de usuario
        //nft de artista

        [Required(ErrorMessage = "Campo obligatorio.")]
        
        public string Cuit { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string CarnSanitario { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string Habilitacion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string MedioPago { get; set; }//AGREGAR LISTA DE MEDIOS DE PAGOS POSIBLES O ACEPTADOS

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string FotCarne { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string NombEstudio { get; set; }

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
