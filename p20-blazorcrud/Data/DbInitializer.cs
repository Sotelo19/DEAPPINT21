using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace p20_blazorcrud.Data { 
    public class DbInitializer {

        public static void Inicializar(AppDBContext context) {
            context.Database.EnsureCreated();
            if(context.Employees.Any()) {
                return;
            }
            var employees = new Employee[] {
                new Employee {EmployeeName="Carlos Castaneda Ramirez",Gender="Male",City="Zacatecas",Designation="Profesor"},
                new Employee {EmployeeName="Blanca Solis Recendez",Gender="Female",City="Fresnillo",Designation="Profesora"},
                new Employee {EmployeeName="Juan Villa Cisneros",Gender="Male",City="Zacatecas",Designation="Profesor"},
                new Employee {EmployeeName="Uriel Cortez Vargas",Gender="Male",City="Guadalupe",Designation="Trabajador"},
                new Employee {EmployeeName="Ma Concepcion Lopez",Gender="Male",City="Jerez",Designation="Intendente"}
            };
            foreach(Employee emp in employees) {
                context.Employees.Add(emp);
            }
            context.SaveChanges();
        }

    }
}