using GestionProyectos.Shared.Entities;
using System.Net.Http.Json;

namespace GestionProyectos.Client.Services
{
    public class ProyectoService : IProyecto
    {
        private readonly HttpClient _http;
        public ProyectoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProyectoE>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseAPI<List<ProyectoE>>>("");
            if (result!.Success)
                return result.Valor!;
            else
                throw new Exception(result.Mensaje);
        }
    }

}
