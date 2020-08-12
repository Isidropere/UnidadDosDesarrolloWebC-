using DasarrolloWebMVC_Pelicula.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasarrolloWebMVC_Pelicula.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistroPelicula rp = new RegistroPelicula();
            return View(rp.RecuperarTodos());
        }

        public ActionResult Grabar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Grabar(FormCollection collection)
        {
            RegistroPelicula rp = new RegistroPelicula();
            Pelicula peli = new Pelicula
            {
                Titulo = collection["Titulo"].ToString(),
                Director = collection["Director"].ToString(),
                AutorPrincipal = collection["AutorPrincipal"].ToString(),
                NumAutor = int.Parse(collection["NumAutor"].ToString()),
                Duracion = float.Parse(collection["Duracion"].ToString()),
                Estreno = int.Parse(collection["Estreno"].ToString())
            };
            rp.GrabarPelicula(peli);

            return RedirectToAction("Index");
        }
        public ActionResult Borrar(int codigo)
        {
            RegistroPelicula rp = new RegistroPelicula();
            rp.Borrar(codigo);
            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int codigo)
        {
            RegistroPelicula rp = new RegistroPelicula();
            Pelicula rpt = rp.Recuperar(codigo);
            return View(rpt);
        }

        [HttpPost]
        public ActionResult Modificar( FormCollection collection)
        {

            RegistroPelicula rp = new RegistroPelicula();
            Pelicula peli = new Pelicula
            {
                Codigo =  int.Parse(collection["Codigo"].ToString()),
                Titulo = collection["Titulo"].ToString(),
                Director = collection["Director"].ToString(),
                AutorPrincipal = collection["AutorPrincipal"].ToString(),
                NumAutor = int.Parse(collection["NumAutor"].ToString()),
                Duracion = float.Parse(collection["Duracion"].ToString()),
                Estreno = int.Parse(collection["Estreno"].ToString())
            };
            rp.Modificar(peli);
            return RedirectToAction("Index");
        }
    }
}