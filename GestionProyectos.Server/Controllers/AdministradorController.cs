using Microsoft.AspNetCore.Mvc;

namespace GestionProyectos.Server.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
