using System.Collections.Generic;

namespace p17_repasopoo
{
    public class Red {

        public Red() => nodos = new List<Nodo>();

        public Red(string pempresa, string ppropietario, string pdomicilio) : this() =>
            (empresa,propietario,domicilio) = (pempresa,ppropietario,pdomicilio);
         
        public string empresa {get;  set;}
        public string propietario {get;  set;}
        public string domicilio {get;  set;}
        public List<Nodo> nodos {get;  set;}
        public int Mayor {
            get {
                int m=nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos>m) m = n.saltos;
                return m;
            }
        }
        public int Menor {
            get {
                int m=nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos<m) m = n.saltos;
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