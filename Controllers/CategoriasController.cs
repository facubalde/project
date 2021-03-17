namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class CategoriasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
        public IActionResult Guardar(string nombre, string descripcion)
        {
            Categoria nuevaCategoria = new Categoria();
            nuevaCategoria.Nombre = nombre;
            nuevaCategoria.Descripcion = descripcion;

            return View(nuevaCategoria);
        }
    }
}