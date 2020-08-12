using System;
using System.Collections.Generic;
using System.Text;

namespace Practica8_DiplomadoUASDCodeFirst.Model.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha_Inscripcion { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
