using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace segundoexamenparcial.Modelo
{
    public class Generosdepelicula {
        [Key]
        public int IdGenero {get; set;}
        [Required]
        public string TipoGenero {get; set;}
    
    public ICollection<Peliculas> Peliculas {get; set;}
    }
}