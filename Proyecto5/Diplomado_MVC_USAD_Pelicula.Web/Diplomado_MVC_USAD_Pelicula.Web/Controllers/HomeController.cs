using Diplomado_MVC_USAD_Pelicula.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_USAD_Pelicula.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Peliculas = new List<Pelicula>
            {
                new Pelicula{Titulo="The GadFather",Director="Francis ford Coppola",AutorPrincipal="Al pacino",NumeroAutor=30 ,Duracion=2 ,Estreno =1994 },
                new Pelicula{Titulo="The shawshank",Director="Frank Darabont",AutorPrincipal="Morgan Freeman",NumeroAutor=15 ,Duracion=3,Estreno =1972 },
                new Pelicula{Titulo="The Matrix",Director="Lana Wachewski",AutorPrincipal="Keanu Reeves",NumeroAutor=15 , Duracion=  2.30 ,Estreno = 1999},
                new Pelicula{Titulo="City of Gad",Director="Fernando Meirelles",AutorPrincipal="Alexandre Rodrigues",NumeroAutor=10 ,Duracion=3 ,Estreno = 2002},
                new Pelicula{Titulo="Star Wars: Episode IV",Director="Georgr Lucas",AutorPrincipal="Harrison Ford",NumeroAutor=20 ,Duracion= 2.40,Estreno =2007 }
            };
            var ResulPelicula = from Pelicula in Peliculas
                                where Pelicula.Titulo.Contains("The")
                                select Pelicula;
            return View(ResulPelicula);
        }

    }
}