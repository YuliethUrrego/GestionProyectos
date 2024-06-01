using Microsoft.AspNetCore.Mvc;

namespace GestionProyectos.Server.Controllers
{
    public class TareaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
