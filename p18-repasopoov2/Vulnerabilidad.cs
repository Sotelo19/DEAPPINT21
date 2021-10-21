using System;
namespace p17_repasopoo
{
    public class Vulnerabilidad {

        public Vulnerabilidad() {}

        public Vulnerabilidad(string pclave,string pvendedor,string pdescripcion,string ptipo,DateTime pfecha) =>
            (clave,vendedor,descripcion,tipo,fecha) = (pclave,pvendedor,pdescripcion,ptipo,pfecha);

        public string clave {get;  set;}
        public string vendedor {get;  set;}
        public string descripcion {get;  set;}
        public string tipo {get;  set;}
        public DateTime fecha {get;  set;}
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
            $"Clave: {clave,-12} Vendedor: {vendedor,-10} Descripcion: {descripcion,-63} Tipo: {tipo,-8} " +
            $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";

    }
}