using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
using System.Linq;
namespace HolaMundoMVC
{

    public class AlumnoController : Controller
    {



        public IActionResult Index() //* solamente envia una Alumno
        {
            return View(new Alumno { Nombre = "Pepé Peréz", UniqueId = Guid.NewGuid().ToString() });
        }


        public IActionResult MultiAlumno() //todo- envia una lista
        {


            var listaAlumnos = GenerarAlumnosAlAzar(); //! llamo a la acción GenerarAlumnosAlAzar en linea 41
            ViewBag.CosasDinamicas = "La monga";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", listaAlumnos);
        }


        private List<Alumno> GenerarAlumnosAlAzar()
        {

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }

    }
}



