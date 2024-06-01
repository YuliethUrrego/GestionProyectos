using GestionProyectos.Shared.Entities;

namespace GestionProyectos.Client.Services
{
    public class RolService: IRol
    {
        private readonly HttpClient _http;
        public RolService(HttpClient http)
        {
            _http = http;
        }

    }
}
