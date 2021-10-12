using System.Collections.Generic;
using System;

namespace p17_repasopoo
{
    public class Nodo {

        public Nodo() => vulnerabilidades = new List<Vulnerabilidad>();

        public Nodo(string pnombrep,string pmateria,string pgrupo,int psalario) : this() =>
            (nombrep,materia,grupo,salario) = (pnombrep,pmateria,pgrupo,psalario);

        public string nombrep {get;  set;}
        public string materia {get;  set;}
        public string grupo {get;  set;}
        public int salario {get;  set;}
       // public string so {get;  set;}
        public List<Vulnerabilidad> vulnerabilidades {get;  set;}
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }



        public void AgregarVulnerabilidad(Vulnerabilidad v) => vulnerabilidades.Add(v);

        public override string ToString() => 
                $"nombre: {nombrep,-12}  materia: {materia,-12} grupo: {grupo,-3} salario: {salario,-3}  " + 
                $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";
    }

}