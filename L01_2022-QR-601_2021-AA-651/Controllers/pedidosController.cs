using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022_QR_601_2021_AA_651.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2022_QR_601_2021_AA_651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pedidosController : ControllerBase
    {
        private readonly restauranteContext _restauranteContexto;

        public pedidosController(restauranteContext restauranteContexto)
        {
            _restauranteContexto = restauranteContexto;

        }

        /// <summary>
        /// EndPoint que retorna el lisado de todos los pedidos existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<Pedidos> listadoPedidos = (from e in _restauranteContexto.Pedidos
                                              select e).ToList();

            if (listadoPedidos.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoPedidos);
        }
    }
}
