using IP_Proyecto3_Diplomado_Web_MVC_UASD_Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IP_Proyecto3_Diplomado_Web_MVC_UASD_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var coches = new List<Coche>
            {
                new Coche{Tipo ="jeep", Marca="BMW",Modelo="X6",Color="Azul"},
                new Coche{Tipo ="Auto", Marca="Mercedes",Modelo="A200",Color="Blanco"},
                new Coche{Tipo ="Jeep", Marca="Porche",Modelo="Cayenne",Color="Negro"},
                new Coche{Tipo ="Auto", Marca="Ford",Modelo="Mustang",Color="Rojo"}
            };

            return View(coches);
        }
    }
}