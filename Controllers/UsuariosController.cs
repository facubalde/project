namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
        public IActionResult Crear()
        {
            return View();
        }
    }
}