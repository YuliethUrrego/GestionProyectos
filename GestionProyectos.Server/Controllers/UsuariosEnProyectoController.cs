using Microsoft.AspNetCore.Mvc;

namespace GestionProyectos.Server.Controllers
{
    public class UsuariosEnProyectoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
