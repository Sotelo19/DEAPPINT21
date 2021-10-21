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
            mired = new Red("Universidad Autonoma de Zacatecas","Ruben Ibarra Reyes","Jardin Juarez 147");
            mired.AgregarNodo(new Nodo("192.168.0.10","servidor",5,10,"linux"));
            mired.AgregarNodo(new Nodo("192.168.0.12","equipoactivo",2,12,"ios"));
            mired.AgregarNodo(new Nodo("192.168.0.20","computadora",8,5,"windows"));
            mired.AgregarNodo(new Nodo("192.168.0.20","servidor",10,22,"linux"));
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2015-1635","microsoft",
                "HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota",DateTime.Parse("04/14/2015")));
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-0004","microsoft",
                "El servicio LSASS permite causar una denegación de servicio","local",DateTime.Parse("01/10/2011")));
            mired.nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-3847", "cisco",
                "Cisco Firepower Management Center XSS","remota",DateTime.Parse("02/21/2017")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2009-2504", "microsoft",
                "Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1" , "local",DateTime.Parse("11/13/2009")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2016-7271", "microsoft",
                "Elevación de privilegios Kernel Segura en Windows 10 Gold","local",DateTime.Parse("12/20/2016")));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-2996", "adobe",
                "Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota",DateTime.Parse("2/15/2017")));
        }

        static void Reporte(Red mired) {
            // Reporte 
            Console.WriteLine("\n>> Datos generales del red:");
            Console.WriteLine($"Empresa     : {mired.empresa}");
            Console.WriteLine($"Propietario : {mired.propietario}");
            Console.WriteLine($"Domicilio   : {mired.domicilio}");
            Console.WriteLine($"Total nodos red : {mired.nodos.Count}");
            Console.WriteLine($"Total vulnerabilidades : {mired.TotVuln}");

            Console.WriteLine("\n>>Datos generales de los nodos:");
            mired.nodos.ForEach(n=>Console.WriteLine(n.ToString()));
            Console.WriteLine($"Mayor numero de saltos: {mired.Mayor} ");
            Console.WriteLine($"Menor numero de saltos: {mired.Menor} ");
            Console.WriteLine("\n>> Vulnerabilidades por nodo:");
            foreach(Nodo n in mired.nodos) {
                Console.WriteLine($"\n> Ip: {n.ip}, Tipo: {n.tipo}\n");
                n.vulnerabilidades.ForEach(v=>Console.WriteLine(v.ToString()));
            }
        }
    }
}
