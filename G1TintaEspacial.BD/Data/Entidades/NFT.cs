using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TINTAESPACIAL.DataBase.data.Entidades;

namespace G1TintaEspacial.BD.Data.Entidades
{
    public class NFT : Usuario
    {
        public int Id { get; set; }
        public int Token { get; set; }
        public string NombreObra { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }
        public string ImagenNFT { get; set; }   
        public string Precio { get; set; }



    }
}
