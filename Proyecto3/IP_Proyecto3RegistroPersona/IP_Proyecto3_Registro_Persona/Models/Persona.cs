using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IP_Proyecto3_Registro_Persona.Models
{
    public class Persona
    {
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string NumeroTelefono { get; set; }

    }
}