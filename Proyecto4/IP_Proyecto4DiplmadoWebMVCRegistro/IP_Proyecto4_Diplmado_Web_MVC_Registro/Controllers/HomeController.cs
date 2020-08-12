﻿using IP_Proyecto4_Diplmado_Web_MVC_Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IP_Proyecto4_Diplmado_Web_MVC_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioVisita()
        {
            return View();
        }
      

        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }
        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }
    }
}