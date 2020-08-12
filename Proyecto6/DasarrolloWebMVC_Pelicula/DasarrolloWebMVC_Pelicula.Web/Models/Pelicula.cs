using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DasarrolloWebMVC_Pelicula.Web.Models
{
    public class Pelicula
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public int NumAutor { get; set; }
        public double Duracion { get; set; }
        public int Estreno { get; set; }
    }
}