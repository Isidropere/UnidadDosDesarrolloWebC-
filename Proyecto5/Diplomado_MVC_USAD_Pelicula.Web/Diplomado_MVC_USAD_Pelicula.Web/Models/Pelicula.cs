using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_USAD_Pelicula.Web.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public double NumeroAutor { get; set; }
        public double Duracion { get; set; }
        public int Estreno { get; set; }
    }
}