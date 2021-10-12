using System.Collections.Generic;
using System;
namespace examencorregido
{
    public class Alumno {

        public Alumno() {}

        public Alumno(string pnombre,int pedad,DateTime pfechaing,bool pbecado,List<float>pcalifs) =>
            (nombre,edad,fecha, becado,califs) = (pnombre,pedad,pfechaing,pbecado,pcalifs);

        public string nombre {get;  set;}
        public int edad {get;  set;}
        public DateTime fechaing {get;  set;}
        public bool becado {get;set;}
        public List<float> califs {get;set;}


        public float prom {
            get{
                float s=0;
                foreach (var c in califs) s+=c;
                return s/califs.Count;
            }
        }

        public override string ToString() =>
            $"Nombre: {nombre,-12} Edad: {edad,-10}  Fecha: {fechaing.ToString("dd/mm/yy"),-8} " +
            $"Becado: {(becado?"Si":"No")} Calificaciones: {string.Join(",",califs)} " +
            $"Prom: {prom} Mensaje: {(prom>=7?"Aprobado":"Reprobado")}";

    }
}