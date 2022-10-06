using G1TintaEspacial.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TINTAESPACIAL.DataBase.data.Entidades;
//using TINTAESPACIAL.DataBase.Entidades;

namespace TINTAESPACIAL.DataBase
{ 
    public class dbcontex: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach ( /// Desactiva la eliminacion en cascada de todas las relaciones
                var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<MedioPago> MedioPagos { get; set; }
        public DbSet<NFT> NFTs { get; set; }

        public dbcontex(DbContextOptions options)
            : base(options)
        {
        }

    }
}
