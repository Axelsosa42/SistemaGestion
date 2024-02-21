using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness.services;
using SistemaGestionEntities.Models;

namespace FerreteriaWebApi.Controllers
{
   
    
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : Controller
        {
            [HttpGet(Name = "ObtenerUsers")]
            public ActionResult<IEnumerable<User>> GetUsers()
            {
                return Ok(UserBussiness.ObtenerUsers().ToArray());
            }

            [HttpGet("{id}", Name = "ObtenerUser")]

            public ActionResult<User> GetUser(int id)
            {
                var resultado = UserBussiness.ObtenerUser(id);

                if (resultado == null)
                    return NotFound();

                return Ok(resultado);
            }

            [HttpPost(Name = "CrearUser")]

            public ActionResult Post([FromBody] User user)
            {
                UserBussiness.CrearUser(user);
                return Ok("Se creó correctamente el User");
            }

            [HttpPut(Name = "ModificarUser")]

            public ActionResult Put([FromBody] User usuario)
            {
                var resultado = UserBussiness.ObtenerUser(usuario.id);
                if (resultado != null)
                {
                       UserBussiness.ModificarUser(usuario);
                }
                else
                {
                    return NotFound();
                }
                return Ok();
            }

            [HttpDelete(Name = "EliminarUser")]

            public ActionResult Delete([FromBody] int id)
            {
                var resultado = UserBussiness.ObtenerUser(id);
                if (resultado != null)
                {
                    UserBussiness.EliminarUser(id);
                }
                else
                {
                    return NotFound();
                }
                return Ok();
            }
        }
    
}
