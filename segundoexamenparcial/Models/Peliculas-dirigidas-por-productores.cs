using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Peliculasdirigidasporproductores {
            public int IdProductor {get; set;}
        public int IdTitulo {get; set;}
    
    public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get; set;}
    public Productores Productores {get; set;}
    }
}