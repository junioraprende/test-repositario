using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
namespace HolaMundoMVC
{

    public class AsignaturaController : Controller
    {
        public IActionResult Index() //todo-solamente envia una asignatura
        {
            return View(new Asignatura { Nombre = "Programación", UniqueId = Guid.NewGuid().ToString() });
        }
        public IActionResult MultiAsignatura() //todo- envia una lista
        {

            #region Carga una lista de asignaturas
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", UniqueId= Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física", UniqueId= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano", UniqueId= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales", UniqueId= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Programación", UniqueId= Guid.NewGuid().ToString()}
                };
            #endregion

            #region Forma-1 de hacerlo carga una sola asignatura
            // var asignatura = new Asignatura
            // {
            //     UniqueId = Guid.NewGuid().ToString(),
            //     Nombre = "Programación"
            // };
            #endregion

            #region Forma-2 de hacerlo una sola asignatura
            // var asignatura = new Asignatura();           
            // asignatura.UniqueId= Guid.NewGuid().ToString();
            // asignatura.Nombre= "Programación";
            #endregion

            ViewBag.CosasDinamicas = "La monga";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}