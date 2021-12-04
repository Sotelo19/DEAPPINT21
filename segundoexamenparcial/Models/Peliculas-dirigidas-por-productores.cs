using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Peliculasdirigidasporproductores {
        [Key]
            public int IdProductor {get; set;}
            [Required]
        public int IdTitulo {get; set;}
    
    public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get; set;}
    public Productores Productores {get; set;}
    }
}