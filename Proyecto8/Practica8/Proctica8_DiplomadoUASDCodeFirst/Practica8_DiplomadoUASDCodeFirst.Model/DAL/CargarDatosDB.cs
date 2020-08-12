using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica8_DiplomadoUASDCodeFirst.Model.Models;

namespace Practica8_DiplomadoUASDCodeFirst.Model.DAL
{
    public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudianteContext>
    {
        protected override void Seed(EstudianteContext context)
        {
            var curso = new List<Curso>
            {
                new Curso {CursoID =1,Descripcion="Diplomado de Desarrollo Web"},
                new Curso {CursoID =2,Descripcion="Clean code General"},
                new Curso {CursoID =3,Descripcion="Diseno de pagina web"},
                new Curso {CursoID =4,Descripcion="Administracion de Servidores"},
                new Curso {CursoID =5,Descripcion="SQL Server"}
            };
            curso.ForEach(y => context.Cursoss.Add(y));
            context.SaveChanges();

            var Estudiantes = new List<Estudiante>
            {
                new Estudiante { EstudianteID =1,Nombre ="Julio",Apellidos="Marte", Fecha_Inscripcion =Convert.ToDateTime("2020-01-01")},
                new Estudiante {EstudianteID =2,Nombre ="Camilo",Apellidos="Vincho", Fecha_Inscripcion =Convert.ToDateTime("2020-01-01")},
                new Estudiante {EstudianteID =3,Nombre ="Jorge",Apellidos="Zapata", Fecha_Inscripcion =Convert.ToDateTime("2020-01-01")},
                new Estudiante {EstudianteID =4,Nombre ="miguel antonio",Apellidos="Reinosos", Fecha_Inscripcion =Convert.ToDateTime("2020-01-01")},
                new Estudiante {EstudianteID =5,Nombre ="ana",Apellidos="Contrera", Fecha_Inscripcion =Convert.ToDateTime("2020-01-01")}
            };
            Estudiantes.ForEach(y => context.Estudiantes.Add(y));
            context.SaveChanges();
            var Inscripcions = new List<Inscripcion>
            {
                new Inscripcion {InscripcionID=1,CursoID =1, EstudianteID =1, Semestre =1},
                new Inscripcion {InscripcionID=2,CursoID =2, EstudianteID =2, Semestre =2},
                new Inscripcion {InscripcionID=3,CursoID =3, EstudianteID =3, Semestre =1},
                new Inscripcion {InscripcionID=4,CursoID =4, EstudianteID =4, Semestre =2},
                new Inscripcion {InscripcionID=5,CursoID =5, EstudianteID =5, Semestre =1}
            };
            Inscripcions.ForEach(y => context.Inscripciones.Add(y));
            context.SaveChanges();

        }
    }
}
