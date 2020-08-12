using IP_Proyecto3_Registro_Persona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IP_Proyecto3_Registro_Persona.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var personas = new List<Persona>
            { 
              new Persona{Nombre="Julio",Apellido="Cueva",Nacionalidad="Dominicana",Sexo="Masculino",Edad= 34,NumeroTelefono="809-560-3636"},
              new Persona{Nombre="Marcos",Apellido="Perez",Nacionalidad="Dominicana",Sexo="Masculino",Edad= 54,NumeroTelefono="809-560-3637"},
              new Persona{Nombre="Antonio",Apellido="Mendez",Nacionalidad="Dominicana",Sexo="Masculino",Edad=56,NumeroTelefono="809-560-3638"},
              new Persona{Nombre="Ana",Apellido="Guzman",Nacionalidad="Dominicana",Sexo="Femenino",Edad= 74,NumeroTelefono="809-560-3639"},
              new Persona{Nombre="Josefa",Apellido="Gutierre",Nacionalidad="Dominicana",Sexo="Femenino",Edad= 23,NumeroTelefono="809-560-3640"},
              new Persona{Nombre="Antonia",Apellido="Gimenez",Nacionalidad="Dominicana",Sexo="Femenino",Edad= 51,NumeroTelefono="809-560-3641"}

            };


            return View(personas);
        }
    }
}