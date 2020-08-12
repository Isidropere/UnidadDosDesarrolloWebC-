using System;
using System.Collections.Generic;
using System.Text;

namespace Practica8_DiplomadoUASDCodeFirst.Model.Models
{
    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        public int Semestre { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Estudiante Estudiante { get; set; }


    }
}
