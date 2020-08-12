using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.DAL
{
   public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
    {
        protected override void Seed(EmpleadoContext context)
        {
            var Departamentos = new List<Departamento>
            { 
                new Departamento{DepartamentoID=1,Descripcion="Recursos Humano",},
                new Departamento{DepartamentoID=2,Descripcion="Programacion",},
                new Departamento{DepartamentoID=3,Descripcion="Mecadeo",},
                new Departamento{DepartamentoID=4,Descripcion="Ventas",},
                new Departamento{DepartamentoID=5,Descripcion="Compras",}

            };
            Departamentos.ForEach(s => context.Departamentos.Add(s));
            context.SaveChanges();

            var Empleado = new List<Empleado> 
            { 
              new Empleado{Nombre="Julios",Apellidos="Mrillo santos",Fecha_Ingreso=DateTime.Parse("2011-08-01")},
              new Empleado{Nombre="Antonio",Apellidos="de la cuz guerrero",Fecha_Ingreso=DateTime.Parse("2011-08-01")},
              new Empleado{Nombre="Carla",Apellidos="Gimenez moya",Fecha_Ingreso=DateTime.Parse("2011-08-01")},
              new Empleado{Nombre="Sofia",Apellidos="Salazar cueva",Fecha_Ingreso=DateTime.Parse("2011-08-01")},
              new Empleado{Nombre="Isarua ",Apellidos="Roa Rojas",Fecha_Ingreso=DateTime.Parse("2011-08-01")},
            };
            Empleado.ForEach(s => context.Empleados.Add(s));
            context.SaveChanges();

            var Registro = new List<Registro>
            {
                new Registro{EmpleadoID =1,DepartemantoID=1,Sueldo =Convert.ToDecimal(10000.00)},
                new Registro{EmpleadoID =2,DepartemantoID=2,Sueldo =Convert.ToDecimal(10000.00)},
                new Registro{EmpleadoID =3,DepartemantoID=3,Sueldo =Convert.ToDecimal(10000.00)},
                new Registro{EmpleadoID =4,DepartemantoID=4,Sueldo =Convert.ToDecimal(10000.00)},
                new Registro{EmpleadoID =5,DepartemantoID=5,Sueldo =Convert.ToDecimal(10000.00)}

            };
            Registro.ForEach(s => context.Registros.Add(s));
            context.SaveChanges();
        }
    }
}
