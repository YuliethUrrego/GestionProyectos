using Microsoft.AspNetCore.Mvc;

namespace GestionProyectos.Server.Controllers
{
    public class ProyectoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
