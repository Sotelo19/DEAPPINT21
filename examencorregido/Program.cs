using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace examencorregido
{
    class Program
    {
        static void Main(string[] args)
        {
            escuela e = null;
            //string arch = "datos.json";
            Inicializa(ref e);
            Reporte(e);         
        }

        static void Inicializa(ref escuela e) {
            // Inicializar datos
            e = new escuela("Universidad de Nuevo Leon ","José Ibarra Reyes","Jardin Juarez 147");
            e.AgregarProfesor(new Profesor("joerge diaz",DateTime.Parse("1/1/2019"),"1A","Fisica",1200f));
            e.AgregarProfesor(new Profesor("maria perez",DateTime.Parse("10/2/2019"),"2A","algebra",3400f));
            e.AgregarProfesor(new Profesor("claudia sid",DateTime.Parse("1/4/2019"),"4A","calculo",3800f));
            e.AgregarProfesor(new Profesor("carlos lopez",DateTime.Parse("1/3/2019"),"8A","quimica",100f));
            
            e.Profesores[0].AgregarAlumno(new Alumno("fatima soto",22,DateTime.Parse("1/1/2019"),true,new List<float>{7,7,7}));
            e.Profesores[0].AgregarAlumno(new Alumno("damian diaz",23,DateTime.Parse("1/10/2016"),true,new List<float>{8,8,8}));
            e.Profesores[1].AgregarAlumno(new Alumno("carlos soto", 24,DateTime.Parse("1/1/2018"),false,new List<float>{6,6,6}));
            e.Profesores[2].AgregarAlumno(new Alumno("maria ochoa", 21,DateTime.Parse("1/10/2018"),false,new List<float>{9,9,9}));
            e.Profesores[2].AgregarAlumno(new Alumno("carlos diaz", 20,DateTime.Parse("1/10/2018"),true,new List<float>{8,8,8}));
            e.Profesores[2].AgregarAlumno(new Alumno("jose ochoa", 22,DateTime.Parse("1/10/2016"),false,new List<float>{6,6,6}));
        }

        static void Reporte(escuela e) {
            // Reporte 
            Console.WriteLine("\n>> Datos de la escuela:");
            Console.WriteLine($"Nombre     : {e.nombre}");
            Console.WriteLine($"Encargado : {e.encargado}");
            Console.WriteLine($"Domicilio   : {e.domicilio}");

            Console.WriteLine($"Total de Profesores : {e.Profesores.Count}");
            Console.WriteLine($"Total Alumnos : {e.TotalAlumnos}");
            Console.WriteLine($"Total Alumnos becados: {e.TotalBecados}");
             Console.WriteLine($"Total de dalario de Profesores : {e.TotalSalario.N2}");
            

            Console.WriteLine("\n>>Datos generales de los Profesores:");
            e.Profesores.ForEach(p=>Console.WriteLine(p.ToString()));
            Console.WriteLine($"Mayor numero de salario: {e.Mayor:N2} ");
            Console.WriteLine($"Menor numero de salario: {e.Menor:N2} ");

            Console.WriteLine("\n>> Alumnos por Profesor:");
            foreach (var p in e.Profesores){
                WriteLine($"\nNombre:{p.nombrea}, Grupo: {p.grupo}\n");
                if(p.Alumnoes.Count>0){
                    p.Alumnoes.ForEach(a=>Console.WriteLine(a.ToString()));
                    WriteLine($"\nMayor Promedio: {p.PromedioMayor}");
                    WriteLine($"Menor Promedio: {p.PromedioMenor}");
                    WriteLine($"Total Becados: {p.TotalBecados}");
                }else{WriteLine("No tiene alumnos aun" ) ; }
            }
        }
    }
}
