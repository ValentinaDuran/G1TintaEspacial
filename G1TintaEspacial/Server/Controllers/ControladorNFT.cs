using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TINTAESPACIAL.DataBase;
using G1TintaEspacial.BD.Data.Entidades;

namespace G1TintaEspacial.Server.Controllers
{   
    [ApiController]
    [Route("api/NFT")]
    public class ControladorNFT : ControllerBase
    {
        private readonly dbcontex contex;
        public ControladorNFT(dbcontex context)
        {
            this.contex = contex;
        }
        [HttpGet]
         public async Task<ActionResult<List<NFT>>> Get()
         {
                return await contex.NFTs.ToListAsync();

         }
    }
    [ApiController]
    [Route("api/NFT")]
    public class NFTController : ControllerBase
    {
        private readonly dbcontex contex;

        public NFTController(dbcontex contex)
        {
            this.contex = contex;
        }
        #region GET
        [HttpGet]
        public async Task<ActionResult<List<NFT>>> Get()
        {
            return await contex.NFTs.ToListAsync();
        }
        #endregion

        #region GET ID
        [HttpGet("id:int")]
        public async Task<ActionResult<NFT>> Get(int id)
        {
            var NFT = await contex.NFTs.Where(e => e.Id == id).FirstOrDefaultAsync();
            if (NFT = null)
            {
                return NotFound($"No existe el NFT con dicha ID={id}");
            }
            return NFT;
        }
        #endregion




    }

    #region GET STRING
    /*[HttpGet("codigo:string")]
    public async Task<ActionResult<NFT>> Get(int id)
    {
        var Token = await contex.NFTs.Where(e => e.Id == id).FirstOrDefaultAsync();
        if (NFT = null)
        {
            return NotFound($"No existe el NFT con dicha ID={id}");
        }
        return NFT;
    }*/
    #endregion


    //    [HttpGet("id:int")]
    //    public async Task<ActionResult<Estilos>> Get(int id)
    //    {
    //        var Estilos = await contex.Estilos.Where(e => e.Id == id).FirstOrDefaultAsync();
    //        if (Estilos = null)
    //        {
    //            return NotFound($"No existe el estilo con dicha ID={id}");
    //        }
    //        return Estilos;
    //    }

    //    [HttpGet("codigo:string")]
    //    public async Task<ActionResult<Estilos>> Get(int id)
    //    {
    //        var Estilos = await contex.Estilos.Where(e => e.Id == id).FirstOrDefaultAsync();
    //        if (Estilos = null)
    //        {
    //
    //            return NotFound($"No existe el estilo con dicha ID={id}");
    //        }
    //        return Estilos;
    //    }
    //}

}
