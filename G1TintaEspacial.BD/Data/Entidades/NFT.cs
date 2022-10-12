using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TINTAESPACIAL.DataBase.data.Entidades;

namespace G1TintaEspacial.BD.Data.Entidades
{
    //[Index(nameof(Id), Name = "NFT_UQ", IsUnique = true)]
    public class NFT //: Usuario 
    {
        public int Id { get; set; }
        public int Token { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string NombreObra { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Autor { get; set; }
        
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string ImagenNFT { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int Precio { get; set; }

        //agregar relacion de nft con usuarios

        //public int UsuarioId { get; set; } //clave foranea de conecta nft con usuario
        //public Usuario Usuario { get; set; }//propiedad de tipo medio de pag. relacion 1=1

    }
}
