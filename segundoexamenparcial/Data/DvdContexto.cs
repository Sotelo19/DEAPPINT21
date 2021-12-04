using Microsoft.EntityFrameworkCore;
using segundoexamenparcial.Modelo;

namespace segundoexamenparcial.Data{
public class DvdContexto : DbContext{

    public DvdContexto(DbContextOptions<DvdContexto> opciones)
    : base(opciones) {}

    public Db<Actores> Actores {get; set;}
    public Db<Certificadosdepeliculas> Certificadosdepeliculas {get; set;}
    public Db<Generosdepelicula> Generosdepeliculas {get; set;}
    public Db<Peliculasdirigidasporproductores> Peliculasdirigidasporproductores {get; set;}
    public Db<Peliculas> Peliculas {get; set;}
    public Db<Productores> Productores {get; set;}
    public Db<Rolesdeactoresenpeliculas> Rolesdeactoresenpeliculas {get; set;}
    public Db<Roles> Roles {get; set;}
    
    protected override void OnModelCreating(ModelBuilder Modelo){
        Modelo.Entity<Rolesdeactoresenpeliculas>{}.maskey{K=> new{k.IdTitulo, k.IdActor,k.IdTiporol}};
         Modelo.Entity<Peliculasdirigidasporproductores>{}.maskey{K=> new{k.IdProductor, k.IdTitulo}};
    } 
}

}