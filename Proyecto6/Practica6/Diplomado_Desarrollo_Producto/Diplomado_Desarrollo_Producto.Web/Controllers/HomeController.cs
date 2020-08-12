using Diplomado_Desarrollo_Producto.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_Desarrollo_Producto.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistroProducto Productos = new RegistroProducto();
            return View(Productos.RecuperarTodosRegistro());
        }

        public ActionResult SalvarDatos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SalvarDatos(FormCollection collection)
        {
            RegistroProducto Productos = new RegistroProducto();

            Producto Produc = new Producto
            {
                Descripcion =collection["Descripcion"].ToString(),
                Tipo = collection["Tipo"].ToString(),
                Precio = float.Parse(collection["Precio"].ToString()),
            };
            Productos.GrabarProductoRegistro(Produc);
            return RedirectToAction("Index");
        }
        public ActionResult BorrarProducto(int id)
        {
            RegistroProducto Productos = new RegistroProducto();
            Productos.BorrarUnoRegistro(id);
            return View();
        }

        public ActionResult Modificar(int ID)
        {
            RegistroProducto Productos = new RegistroProducto();
            Producto rpt = Productos.RecuperaUnoRegistro(ID);
            return View(rpt);
        }

        [HttpPost]
        public ActionResult Modificar(FormCollection collection)
        {
            RegistroProducto Productos = new RegistroProducto();

            Producto Produc = new Producto
            {
                ID = int.Parse( collection["ID"].ToString()),
                Descripcion = collection["Descripcion"].ToString(),
                Tipo = collection["Tipo"].ToString(),
                Precio = float.Parse(collection["Precio"].ToString()),
            };
            Productos.ModificarActualizar(Produc);
            return RedirectToAction("Index");
        }

    }
}