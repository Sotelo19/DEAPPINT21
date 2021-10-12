using System.Collections.Generic;
using System;

namespace examencorregido
{
    public class Profesores {

        public Profesores() => alumnos = new List<Alumno>();

        public Profesores(string pnombre,string pmateria,string pgrupo,int psalario,string pso,DateTime pfechaing) : this() =>
            (nombre,materia,grupo,salario,fechaing) = (pnombre,pmateria,pgrupo,psalario,pfechaing);

        public string nombre {get;  set;}
        public DateTime fechaing {get; set;}
        public string materia {get;  set;}
        public string grupo {get;  set;}
        public int salario {get;  set;}
        public List<Alumno> alumnos {get;  set;}

        public void AgregarAlumno(Alumno a) => alumnos.Add(a);

        public float PromedioMayor {
            get {
                float m=alumnos[0].prom;
                foreach (var a in alumnos)
                    if(a.prom>m) m=a.prom;
                return m;
            }
        }

        public float PromedioMenor {
            get {
                float m=alumnos[0].prom;
                foreach (var a in alumnos)
                    if(a.prom>m) m = a.prom;
                return m;
            }
        }

        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public int TotalBecados {
            get {
                int s=0;
                foreach (var a in alumnos)
                    if(a.becado) s++;
                return s;
            }
        }

    

        public override string ToString() => 
                $"Nombre: {nombre,-12}  Matxeria: {materia,-12} Grupos: {grupo,-3} Salario: {salario,-3}  Alumnos: {alumnos.Count} " + 
                $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";
                
    }

}