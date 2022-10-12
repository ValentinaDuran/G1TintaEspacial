using G1TintaEspacial.BD.Data.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TINTAESPACIAL.DataBase;

namespace G1TintaEspacial.Server.Controllers
{
    [Route("api/MedioPago")]
    [ApiController]
    public class MedioPagoController : ControllerBase
    {
        private readonly dbcontex contex;
        public MedioPagoController(dbcontex contex)
        {
            this.contex = contex;
        }
        #region GET
        [HttpGet]
        public async Task<ActionResult<List<MedioPago>>> Get()
        {
            return await contex.MedioPagos.ToListAsync();
        }
        #endregion

        #region GET ALIAS STRING
        [HttpGet("alias:string")]
        public async Task<ActionResult<MedioPago>> Get(string Alias)
        {
            var medioPago = await contex.MedioPagos.Where(e => e.Alias == Alias).FirstOrDefaultAsync();
            if (medioPago == null)
            {
                return NotFound($"No existe el Medio de pago con dicho alias={Alias}");
            }
            return medioPago;
        }
        #endregion

        #region GET ID INT *esta comentado porque no si se va*
        
       //[HttpGet("id:int")]
       // public async Task<ActionResult<MedioPago>> Get(int Id)
       // {
       //     var mediopago = await contex.NFTs.Where(e => e.Id == Id).FirstOrDefaultAsync();
       //     if (mediopago == null)
       //     {
       //         return NotFound($"No existe el Medio de pago con dich ID={Id}");
       //     }
       //     return mediopago;
       // }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<MedioPago>> Get(int id)
        {

            var venta = await contex.MedioPagos.FindAsync(id);


            if (venta == null)
            {
                return NotFound($"No existe venta de id: {id}");
            }
            return venta;
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<ActionResult<int>> Post(MedioPago medioPago)
        {
            try
            {
                contex.MedioPagos.Add(medioPago);
                await contex.SaveChangesAsync();
                return medioPago.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        #endregion

        //#region PUT 
        //[HttpPut("{id:int}")]
        //public ActionResult Put(int Id, [FromBody] MedioPago medioPago)
        //{
        //    if (Id != medioPago.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var mati2 = contex.MedioPagos.Where(e => e.Id == Id).FirstOrDefault();
        //    if (mati2 == null)
        //    {
        //        return NotFound("No existe el NFT a modificar");
        //    }

        //    mati2.Id = mati2.Id;
        //    mati2.Alias = mati2.Alias;

        //    try
        //    {
        //        //throw(new Exception("Cualquier Verdura"));
        //        contex.MedioPagos.Update(mati2);
        //        contex.SaveChanges();
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
        //    }
        //}
        //#endregion

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] MedioPago mediopago)//(int id, [FromBody] Producto.BD.Data.Entidades.Cliente client)
        {
            if (id != mediopago.Id)
            {
                return BadRequest("Datos Incorrectos");
            }

            var ventas = contex.MedioPagos.Where(e => e.Id == id).FirstOrDefault();

            if (ventas == null)
            {
                return NotFound("No existe  el cliente buscada");
            }

            ventas.Alias = mediopago.Alias;
            
            try
            {
                contex.MedioPagos.Update(ventas);
                contex.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }
        #region PUT STRING
        [HttpPut("{alias:string}")]
        public ActionResult Put(string alias, [FromBody] MedioPago medioPago)
        {
            if (alias != medioPago.Alias)
            {
                return BadRequest("Datos incorrectos");
            }

            var mati2 = contex.MedioPagos.Where(e => e.Alias == alias).FirstOrDefault();
            if (mati2 == null)
            {
                return NotFound("No existe el Alias a modificar");
            }

            mati2.Id = mati2.Id;
            mati2.Alias = mati2.Alias;

            try
            {
                //throw(new Exception("Cualquier Verdura"));
                contex.MedioPagos.Update(mati2);
                contex.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }
        #endregion  
        #region DELETE
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var mati2 = contex.MedioPagos.Where(x => x.Id == id).FirstOrDefault();

            if (mati2 == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }
            try
            {
                contex.MedioPagos.Remove(mati2);
                contex.SaveChanges();
                return Ok($"El registro de {mati2.Id} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
        #endregion
    }
}
