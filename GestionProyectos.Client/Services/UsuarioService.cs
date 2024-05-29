using GestionProyectos.Shared.Entities;
using System.Net.Http.Json;

namespace GestionProyectos.Client.Services
{
    public class UsuarioService : IUsuario
    {

        private readonly HttpClient _http;
        public UsuarioService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<UsuarioE>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseAPI<List<UsuarioE>>>("api/Usuario/ListarUsuarios");
            if (result!.Success)
                return result.Valor!;
            else
                throw new Exception(result.Mensaje);
        }
    }
}
