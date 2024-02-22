using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness.services;
using SistemaGestionEntities.Models;

namespace FerreteriaWebApi.Controllers
{




    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : Controller
    {
        [HttpGet(Name = "ObtenerSale")]
        public ActionResult<IEnumerable<Sale>> GetSale()
        {
            return Ok(SaleBussiness.ObtenerSales().ToArray());
        }

        [HttpGet("{id}", Name = "ObtenerSale")]

        public ActionResult<Sale> GetSaleo(int id)
        {
            var resultado = SaleBussiness.ObtenerSale(id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpPost(Name = "CrearSale")]

        public ActionResult Post([FromBody] Sale Sale)
        {
            SaleBussiness.CrearSale(Sale);
            return Ok("Se creó correctamente venta");
        }

        [HttpPut(Name = "ModificarVentas")]

        public ActionResult Put([FromBody] Sale Sale)
        {
            var resultado = SaleBussiness.ObtenerSales(Sale.Id);
            if (resultado != null)
            {
                SaleBussiness.ModificarSale(Sale);
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete(Name = "EliminarSaleo")]

        public ActionResult Delete([FromBody] int id)
        {
            var resultado = SaleBussiness.ObtenerSaleo(id);
            if (resultado != null)
            {
                SaleBussiness.EliminarSaleo(id);
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
    }



}
