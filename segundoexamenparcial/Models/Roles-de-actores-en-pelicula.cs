using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Rolesdeactoresenpelicula {
        [Key]
        public int IdTitulo {get; set;}
        [Required]
        public int IdActor {get; set;}
        public int IdTiporol {get; set;}
        public string NameC {get; set;}
        public string Descripcion {get; set;}
    

    public Pelicula Pelicula {get; set;}
    public Actores Actores {get; set;}
    public Roles Roles {get; set;}
    }
}