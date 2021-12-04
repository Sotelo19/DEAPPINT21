using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores {
        [Key]
        public int IdProductor {get; set;}
        [Required]
        public string NombreProductor {get; set;}
        public string email {get; set;}
        public string Sitioweb {get; set;}

        public Productores Productores {get; set;}
        public Peliculas Peliculas{get; set;}
    }
}