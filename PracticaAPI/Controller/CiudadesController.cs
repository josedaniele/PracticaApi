using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaAPI.Services;

namespace PracticaAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]

    public class CiudadesController : ControllerBase
    {
        private CiudadService _ciudadService;
        public CiudadesController(CiudadService Ciud)
        {
            _ciudadService = Ciud;
        }
        [HttpGet]
        public IActionResult GetCiudades()
        {
            return Ok(_ciudadService.GetCiudades());
        }

        [HttpGet("{id}")]
        public IActionResult GetCiudadesId(int id)
        {
            var ciudad = _ciudadService.GetCiudad(id);
            if(ciudad != null) {
            
            return Ok(ciudad);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
