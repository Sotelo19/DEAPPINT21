using System;
namespace p17_repasopoo
{
    public class Vulnerabilidad {

        public Vulnerabilidad() {}

        public Vulnerabilidad(string pnombrea,int pvendedor,string ptipo,DateTime pfecha) =>
            (nombrea,edad,tipo,fecha) = (pnombrea,pvendedor,ptipo,pfecha);

        public string nombrea {get;  set;}
        public int edad {get;  set;}
      //public string descripcion {get;  set;}
        public string tipo {get;  set;}
        public DateTime fecha {get;  set;}
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
            $"nombrea: {nombrea,-12} edad: {edad,-10}  Tipo: {tipo,-8} " +
            $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";

    }
}