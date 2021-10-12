using System;
using System.IO;

namespace p17_repasopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Red mired = null;
            string arch = "datos.json";
           
            
            if(File.Exists(arch)) {
                // cargar los datos del archivo que ya existe en disco: datos.xml
                Console.WriteLine($"Cargando los datos del archivo de disco : {arch}");
                //Utils.LeerXml(arch, ref mired);
                Utils.LeerJson(arch, ref mired);
            }
            else {
                Console.WriteLine($"Inicializando datos desde el codigo ...");
                Inicializa(ref mired);  
                // grabar los datos al disco en el archivo datos.xml
                //Utils.GrabarXml(arch, mired);
                Utils.GrabarJson(arch, mired);
            }

            Reporte(mired);         
        }

        static void Inicializa(ref Red mired) {
            // Inicializar datos
            mired = new Red("Universidad Patito SA de CV","Ing. Juan Perez","Av. De la Juventud 348");
            mired.AgregarNodo(new Nodo("toño","español"," A","linux"));
            mired.AgregarNodo(new Nodo("juan ","historia","2B","ios"));
            mired.AgregarNodo(new Nodo("sotelo","geografia","3C","windows"));
            mired.AgregarNodo(new Nodo("maria","español","1A","linux"));
           
             {
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("pepito",25,DateTime.Parse("04/14/2016")));
            mired.nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("dora",31,DateTime.Parse("02/21/2017")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("cris",22,DateTime.Parse("11/13/2019")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("ale",19,DateTime.Parse("12/20/2016")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("fatima",18,DateTime.Parse("2/15/2017")));
        
             }        
        }

        static void Reporte(Red mired) {
            // Reporte 
            Console.WriteLine("\n>> Datos de la escuela:");
            Console.WriteLine($"Nombre     : {mired.nombre}");
            Console.WriteLine($"Encargado : {mired.encargado}");
            Console.WriteLine($"Domicilio   : {mired.domicilio}");
            Console.WriteLine($"Total de Profesores : {mired.nodos.Count}");
            Console.WriteLine($"Total Alumnos : {mired.TotVuln}");

            Console.WriteLine("\n>>Datos generales del profesor:");
            mired.nodos.ForEach(n=>Console.WriteLine(n.ToString()));
            Console.WriteLine($"Mayor salario: {mired.MayorSalario} ");
            Console.WriteLine($"Menor salario: {mired.MenorSalario} ");
            Console.WriteLine("\n>> Vulnerabilidades por nodo:");
            foreach(Nodo n in mired.nodos) {
                Console.WriteLine($"\n> nombrep: {n.nombrep}, materia: {n.materia}\n");
                n.vulnerabilidades.ForEach(v=>Console.WriteLine(v.ToString()));
            }
        }
    }
}
