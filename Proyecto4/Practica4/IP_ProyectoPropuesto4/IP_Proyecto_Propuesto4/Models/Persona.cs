using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace IP_Proyecto_Propuesto4.Models
{
    public class Persona
    {
    
        public void Grabar (string Nombre,string Cedula, string Telefono, string Correo)
        {
            StreamWriter archivar = new StreamWriter(HostingEnvironment.MapPath("~") +"/App_Data/PersonaDatos.txt",true);
           archivar.WriteLine($"| Nombre: {Nombre} | Cedula: {Cedula} | Telefono: {Telefono} | Correo: {Correo}|<hr>");
            archivar.Close();
        }

        public string LeerDatos()
        {
            StreamReader archivar = new StreamReader(HostingEnvironment.MapPath("~")+ "/App_Data/PersonaDatos.txt");
            string TodoDatos = archivar.ReadToEnd();
            archivar.Close();
            return TodoDatos;
        }
    }
}