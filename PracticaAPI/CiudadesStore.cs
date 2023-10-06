using PracticaAPI.Models;
using PracticaAPI.Models.Ciudades.API.Models;

namespace PracticaAPI
{
    public class CiudadesDataStore
    {
        public List<CiudadDto> Ciudades { get; set; }


        public CiudadesDataStore()
        {
            Ciudades = new List<CiudadDto>()
        { new CiudadDto()
        {
            Id = 1,
            Name = "Test",
            Description = "Test"
        },
        new CiudadDto()
        {
            Id = 2,
            Name = "Rosario",
            Description = "Ciudad de Rosario"
        }

        };

        }


    }
}
