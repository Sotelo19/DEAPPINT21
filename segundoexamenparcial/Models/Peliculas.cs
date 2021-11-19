using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
public class Peliculas{
       public int IdTitulo {get; set;}
       public string NombreP {get; set;}
       public string HisPelicula {get; set;}
       public dateline fechacreada {get; set;}
       public int duracion {get; set;}
       public string IdGenero {get; set;} 
       public int IdCertificacion {get; set;}
       public string Informacion {get; set;}

public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get; set;}
public Peliculas Peliculas {get; set;}
public Actores Actores {get; set;}
public Generosdepelicula Generosdepelicula {get; set;}
public Certificadosdepeliculas Certificadosdepeliculas {get; set;}
}
}