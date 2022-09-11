using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
namespace HolaMundoMVC
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundación = 1995;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";

            ViewBag.CosasDinamicas = "La monga";

            return View(escuela);
            //c# ya sabe por convencion que me interesa regresar la vista de Index
        }
    }
}