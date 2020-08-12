using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_Desarrollo_Producto.Web.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public float Precio { get; set; }

    }
}