using System.Collections.Generic;

namespace p17_repasopoo
{
    public class Red {

        public Red() => nodos = new List<Nodo>();

        public Red(string pNombre, string pEncargado, string pDomicilio) : this() =>
            (Nombre,Encargado,Domicilio) = (pNombre,pEncargado,pDomicilio );
         
        public string Nombre {get;  set;}
        public string Encargado {get;  set;}
        public string Domicilio {get;  set;}
        public List<Nodo> nodos {get;  set;}
        public int MayorSalario {
            get {
                int m=nodos[0].salario;
                foreach (Nodo n in nodos)
                    if(n.salario>m) m = n.salario;
                return m;
            }
        }
        public int MenorSalario {
            get {
                int m=nodos[0].salario;
                foreach (Nodo n in nodos)
                    if(n.salario<m) m = n.salario;
                return m;
            }
        }
        public int TotVuln {
            get {
                int s=0;
                foreach (Nodo n in nodos)
                     s = s + n.vulnerabilidades.Count;
                return s;
            }
        }
        
        public void AgregarNodo(Nodo n) => nodos.Add(n);

    }


}