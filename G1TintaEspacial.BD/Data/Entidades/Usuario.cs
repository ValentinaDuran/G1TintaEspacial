using G1TintaEspacial.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
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
    //[Index(nameof(MedicoId), nameof(EspecialidadId), Name = "MatriculaMedicoIdEspecialidadId_UQ", IsUnique = true)]
    public class Usuario
    {
        #region Usuario

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo es obligatoria.")]
        [MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string Contraseña { get; set; }

        //[Required(ErrorMessage = "La Imagen de perfil es obligatorio.")]
        //[MaxLength(255, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string? ImagePerfil { get; set; }
        #endregion

        #region TatuadorPropiedades
        public string MercadoPago { get; set; }// cambiar medio de pago por mercado pago?

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Telefono { get; set; }

        #endregion

        #region Relaciones
        // Relacion con NFT 1 usuario tatuador tiene uno o muchos nfts
        public List<NFT> NFTs { get; set; }

        //Relacion con Medio de pago/ Mercado apago
        //public List<MedioPago> MediosPagos { get; set; }

        //como hacer con la relaicion usuario y medio de pago?

        public int MedioPagoId { get; set; }//clave foanea  que conecta medio de pago con usuarios----id+propiedad siempre unidos y en ese orden id arriba y propiedad abajo
        public MedioPago MedioPago { get; set; }//propiedad de tipo medio de pag. relacion 1=1
        #endregion




    }


}










