using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022_QR_601_2021_AA_651.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2022_QR_601_2021_AA_651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clientesController : ControllerBase
    {
        private readonly restauranteContext _restauranteContexto;

        public clientesController(restauranteContext restauranteContexto)
        {
            _restauranteContexto = restauranteContexto;

        }

        /// <summary>
        /// EndPoint que retorna el lisado de todos los clientes existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<Clientes> listadoClientes = (from e in _restauranteContexto.Clientes
                                            select e).ToList();

            if (listadoClientes.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoClientes);
        }


        /// <summary>
        /// EndPoint que retorna el lisado de todos los clientes existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById/{id}")]

        public IActionResult Get(int id)
        {
            Clientes? Clientes = (from e in _restauranteContexto.Clientes
                                              select e).FirstOrDefault();

            if (Clientes  == null)
            {
                return NotFound();
            }
            return Ok(Clientes);
        }



        /// <summary>
        /// EndPoint que retorna el lisado de todos los clientes existentes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Find/{filtro}")]

        public IActionResult FindByDescription(string filtro)
        {
            Clientes? Clientes = (from e in _restauranteContexto.Clientes
                                  where e.direccion.Contains(filtro)
                                  select e).FirstOrDefault();

            if (Clientes == null)
            {
                return NotFound();
            }
            return Ok(Clientes);
        }









    }


}
