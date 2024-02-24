using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022_QR_601_2021_AA_651.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2022_QR_601_2021_AA_651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatosController : ControllerBase
    {

        private readonly restauranteContext _restauranteContexto;

        public PlatosController(restauranteContext restauranteContexto)
        {
            _restauranteContexto = restauranteContexto;

        }

        /// <summary>
        /// EndPoint que retorna el lisado de todos los platos existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<Platos> listadoPlatos = (from e in _restauranteContexto.Platos
                                            select e).ToList();

            if (listadoPlatos.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoPlatos);
        }
    }
}
