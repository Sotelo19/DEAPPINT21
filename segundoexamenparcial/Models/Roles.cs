using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Roles {
    [Key]
    public int IdTiporol {get; set;}
    public string Tiporol {get; set;}

    public ICollection<Rolesdeactoresenpeliculas> Rolesdeactoresenpeliculas {get; set;}
    }
}