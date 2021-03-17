namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class ArticulosController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
    }
}