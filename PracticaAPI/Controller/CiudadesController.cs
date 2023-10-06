using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaAPI.Services;

namespace PracticaAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]

    public class CiudadesController : ControllerBase
    {
        //Inyeccion de dependencia
        private CiudadService _ciudadService;

        //Constructor
        public CiudadesController(CiudadService ciud)
        {
            _ciudadService = ciud;
        }
        //Metodos de consulta
        [HttpGet]
        public IActionResult ObtenerCiudades()
        {
            var Ciudades = _ciudadService.GetCiudades();
            return Ok(Ciudades);
        }

        [HttpGet("{id}")]
        public IActionResult GetCiudadbYId(int id)
        {
            var ciudad = _ciudadService.GetCiudad(id);
            if(ciudad == null) 
            {
             return BadRequest("No encontrado");
            }
            else
            {
                return Ok(ciudad.Name);
            }

        }
    }
}
