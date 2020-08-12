using IP_Proyecto_Propuesto4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IP_Proyecto_Propuesto4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioPeronas()
        {
   
            return View();
        }
        public ActionResult CargarPersonas()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();
            Persona Person = new Persona();
            Person.Grabar(nombre, cedula, telefono, correo);
            return View();
        }
        public ActionResult ListadosPersonas()
        {
            Persona Person = new Persona();
            string LeerTodo = Person.LeerDatos();
            ViewData["Person"] = LeerTodo;
            return View();
        }

        public ActionResult VistaMejorada()
        {

            return View();
        }

        }
}