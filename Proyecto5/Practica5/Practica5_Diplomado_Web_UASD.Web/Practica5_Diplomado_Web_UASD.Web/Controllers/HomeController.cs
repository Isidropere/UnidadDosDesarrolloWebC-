using Practica5_Diplomado_Web_UASD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica5_Diplomado_Web_UASD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var DatosProductos = new List<Producto>
            {
             
                new Producto{ IdProducto=1, Decripcion="Boligrafo",Precio=8.35},
                new Producto{ IdProducto=2, Decripcion="Cuaderno grande",Precio=21.5},
                new Producto{ IdProducto=3, Decripcion="Cuadernos pequeño",Precio=10},
                new Producto{ IdProducto=4, Decripcion="Folio 500 uds",Precio=550.25},
                new Producto{ IdProducto=5, Decripcion="Grapadora",Precio=85.25},
                new Producto{ IdProducto=6, Decripcion="Tijeras",Precio=62},
                new Producto{ IdProducto=7, Decripcion="Cinta Adhesiva",Precio=45.10},
                new Producto{ IdProducto=8, Decripcion="Rotulador",Precio=20.75},
                new Producto{ IdProducto=9, Decripcion="Michila escolar",Precio=800.90},
                new Producto{ IdProducto=10, Decripcion="Pegamento barra",Precio=30.15},
                new Producto{ IdProducto=11, Decripcion="Lapicero",Precio=15.55},
                new Producto{ IdProducto=12, Decripcion="Grapas",Precio=40.90},
               
            };

            var ResultProductos = from Producto in DatosProductos
                                  where Producto.Precio > 20
                                  select Producto;
         
            return View(ResultProductos);
        }
    }
}