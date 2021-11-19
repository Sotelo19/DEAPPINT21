using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Rolesdeactoresenpelicula {
        public int IdTitulo {get; set;}
        public int IdActor {get; set;}
        public int IdTiporol {get; set;}
        public string NameC {get; set;}
        public string Descripcion {get; set;}
    

    public Rolesdeactoresenpelicula Rolesdeactoresenpelicula {get; set;}
    public Actores Amaterno {get; set;}
    public Tiporol Tiporol {get; set;}
    }
}