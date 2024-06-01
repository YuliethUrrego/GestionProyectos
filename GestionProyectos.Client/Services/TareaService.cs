namespace GestionProyectos.Client.Services
{
    public class TareaService : ITarea
    {
        private readonly HttpClient _http;
        public TareaService(HttpClient http)
        {
            _http = http;
        }
    }
}
