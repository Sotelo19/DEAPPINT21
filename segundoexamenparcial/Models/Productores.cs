using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores {
        public int IdProductor {get; set;}
        public string NombreProductor {get; set;}
        public string email {get; set;}
        public string Sitioweb {get; set;}

        public Productores Productores {get; set;}
        public Peliculas Peliculas{get; set;}
    }
}