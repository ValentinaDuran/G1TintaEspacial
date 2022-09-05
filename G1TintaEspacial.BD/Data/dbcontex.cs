using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TINTAESPACIAL.DataBase.data.Entidades;
using TINTAESPACIAL.DataBase.Entidades;

namespace TINTAESPACIAL.DataBase
{ 
    public class dbcontex: DbContext
    {
        public DbSet<UsuarioTatuador> Tatuadores { get; set; }
        public DbSet<UsuarioArtista> Artistas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<UsuarioEstudio> UsuarioEstudios { get; set; }
        public DbSet<UsuarioNFT> UsuarioNFTs { get; set; }

        public dbcontex(DbContextOptions options)
            : base(options)
        {
        }

    }
}
