using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace segundoexamenparcial.Modelo
{
    public class Generosdepelicula {
        public int IdGenero {get; set;}
        public string TipoGenero {get; set;}
    
    public ICollection<Peliculas> Peliculas {get; set;}
    }
}