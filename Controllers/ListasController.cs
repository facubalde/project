namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class ListasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
    }
}