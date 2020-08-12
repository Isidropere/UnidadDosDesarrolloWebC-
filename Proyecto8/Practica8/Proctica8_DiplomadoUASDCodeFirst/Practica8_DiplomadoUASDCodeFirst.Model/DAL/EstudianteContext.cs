using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Practica8_DiplomadoUASDCodeFirst.Model.Models;

namespace Practica8_DiplomadoUASDCodeFirst.Model.DAL
{
   public class EstudianteContext : DbContext
    {
        public EstudianteContext(): base("EstudianteContext")
        {


        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursoss { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }

    }
}
