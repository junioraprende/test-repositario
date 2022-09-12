using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
namespace HolaMundoMVC
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 1995;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.TipoEscuela = TiposEscuela.Secundaria;//ESTA ES UNA ENUMERACION
            escuela.Dirección = "Calle 5, Ave 4, Bogotá, Bogotá.";
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";


            ViewBag.CosasDinamicas = "La monga";

            return View(escuela);
            //c# ya sabe por convencion que me interesa regresar la vista de Index
        }
    }
}