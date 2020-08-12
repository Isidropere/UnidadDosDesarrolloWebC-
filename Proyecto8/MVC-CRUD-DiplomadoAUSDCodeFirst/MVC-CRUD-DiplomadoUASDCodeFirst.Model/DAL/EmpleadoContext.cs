using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.DAL
{
   public class EmpleadoContext:DbContext
    {
        //clase constructor para la conexion a la base de datos 
        public EmpleadoContext() 
            :base("EmpleadoContext") //nombre de la conxion
        {
           
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }

    }
}
