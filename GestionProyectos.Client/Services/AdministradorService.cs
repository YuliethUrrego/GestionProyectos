using GestionProyectos.Shared.Entities;

namespace GestionProyectos.Client.Services
{
    public class AdministradorService : IAdministrador
    {

        private readonly HttpClient _http;
        public AdministradorService(HttpClient http)
        {
            _http = http;
        }
    }
}
