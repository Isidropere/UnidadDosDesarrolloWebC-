using System;
using System.Collections.Generic;
using System.Text;

namespace Practica8_DiplomadoUASDCodeFirst.Model.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
