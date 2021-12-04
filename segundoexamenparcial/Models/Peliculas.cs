using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
public class Peliculas{
       [Key]
       public int IdTitulo {get; set;}
       public string NombreP {get; set;}
       public string HisPelicula {get; set;}
       public dateline fechacreada {get; set;}
       public int duracion {get; set;}
       public string IdGenero {get; set;} 
       public int IdCertificacion {get; set;}
       public string Informacion {get; set;}

       public ICollection<Rolesdeactoresenpelicula> Rolesdeactoresenpeliculas {get; set;}
       public ICollection<Peliculasdirigidasporproductores> Peliculasdirigidasporproductores {get; set;}
       public Certificadosdepeliculas Certificadosdepeliculas {get; set;}
       public Generosdepelicula Generosdepelicula {get; set;}
}
}