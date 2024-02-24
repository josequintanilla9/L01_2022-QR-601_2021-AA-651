using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022_QR_601_2021_AA_651.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2022_QR_601_2021_AA_651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class restauranteController : ControllerBase
    {
        private readonly restauranteContext _restauranteContexto;

        public restauranteController(restauranteContext restauranteContexto)
        {
            _restauranteContexto = restauranteContexto;

        }

        /// <summary>
        /// EndPoint que retorna el lisado de todos los equipos existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<Clientes> listadoEquipo = (from e in _restauranteContexto.Clientes
                                           select e).ToList();

            if (quipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(l);
        }


    }
}
