using PracticaAPI.Models.Ciudades.API.Models;

namespace PracticaAPI.Services
{
    public class CiudadService
    {
        private readonly CiudadesDataStore _dataStore;

        public CiudadService()
        {
            _dataStore = new CiudadesDataStore(); 
        }

        public List<CiudadDto> GetCiudades()
        {
            return _dataStore.Ciudades; 
        }

        public CiudadDto GetCiudad(int id)
        {
            var ciudad = _dataStore.Ciudades.FirstOrDefault(c => c.Id == id);
            return ciudad;
        }
        
    }
}

