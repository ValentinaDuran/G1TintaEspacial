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
        #region GET ID
        [HttpGet("id:int")]
        public async Task<ActionResult<NFT>> Get(int id)
        {
            var NFT = await contex.NFTs.Where(e => e.Id == id).FirstOrDefaultAsync();
            if (NFT == null)
            {
                return NotFound($"No existe el NFT con dicha ID={id}");
            }
            return NFT;
        }
        #endregion

        [HttpPost]
        public async Task<ActionResult<int>> Post(NFT nft)
        {
            try
            {
                contex.NFTs.Add(nft);
                await contex.SaveChangesAsync();
                return nft.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] NFT nFT)
        {
            if (id != nFT.Id)
            {
                return BadRequest("Datos incorrectos");
            }

            var mati = contex.NFTs.Where(e => e.Id == id).FirstOrDefault();
            if (mati == null)
            {
                return NotFound("No existe el NFT a modificar");
            }

            mati.Id = nFT.Id;
            mati.NombreObra = nFT.NombreObra;
            mati.Descripcion = nFT.Descripcion;
            mati.Autor = nFT.Autor;
            mati.Precio = nFT.Precio;
            mati.Token = nFT.Token;
            mati.Precio = nFT.Precio;
            try
            {
                //throw(new Exception("Cualquier Verdura"));
                contex.NFTs.Update(mati);
                contex.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var mati = contex.NFTs.Where(x => x.Id == id).FirstOrDefault();

            if (mati == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }
            try
            {
                contex.NFTs.Remove(mati);
                contex.SaveChanges();
                return Ok($"El registro de {mati.Token} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }

    }

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


