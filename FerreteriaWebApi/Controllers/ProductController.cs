//using Microsoft.AspNetCore.Mvc;
//using SistemaGestionBussiness.services;
//using SistemaGestionEntities.Models;

//namespace FerreteriaWebApi.Controllers
//{




//    [Route("api/[controller]")]
//    [ApiController]
//    public class SaleController : Controller
//    {
//        [HttpGet(Name = "ObtenerProducto")]
//        public ActionResult<IEnumerable<Product>> GetProductos()
//        {
//            return Ok(ProductBussiness.ObtenerProductos().ToArray());
//        }

//        [HttpGet("{id}", Name = "ObtenerProducto")]

//        public ActionResult<Product> GetProducto(int id)
//        {
//            var resultado = ProductBussiness.ObtenerProducto(id);

//            if (resultado == null)
//                return NotFound();

//            return Ok(resultado);
//        }

//        [HttpPost(Name = "CrearProducto")]

//        public ActionResult Post([FromBody] Product producto)
//        {
//            ProductBussiness.CrearProducto(producto);
//            return Ok("Se creó correctamente el Producto");
//        }

//        [HttpPut(Name = "ModificarProducto")]

//        public ActionResult Put([FromBody] Product producto)
//        {
//            var resultado = ProductBussiness.ObtenerProducto(producto.id);
//            if (resultado != null)
//            {
//                ProductBussiness.ModificarProducto(producto);
//            }
//            else
//            {
//                return NotFound();
//            }
//            return Ok();
//        }

//        [HttpDelete(Name = "EliminarProducto")]

//        public ActionResult Delete([FromBody] int id)
//        {
//            var resultado = ProductBussiness.ObtenerProducto(id);
//            if (resultado != null)
//            {
//                ProductBussiness.EliminarProducto(id);
//            }
//            else
//            {
//                return NotFound();
//            }
//            return Ok();
//        }
//    }



//}
