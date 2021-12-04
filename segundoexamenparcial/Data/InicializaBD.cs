using segundoexamenparcial.Modelo;
using System.Linq;
using System;

namespace segundoexamenparcial.Data{
    public class InicializaBD{
        public static void Inicializar(DvdContexto contexto){
            contexto.Database.EnsureCreated();
            if(contexto.Peliculass.Any()){
                return;
            }
            //Agregar Actores
            var actores = new Actores[]{
                new Actores{Nombre="el tunas"},
                new Actores{Nombre="chente"},
                new Actores{Nombre="tonny stark"},
                new Actores{Nombre="Thor"},
                new Actores{Nombre="hulk"},
            };
            foreach (Actores a in actores) contexto.Actoress.Add(a);
            contexto.SaveChanges();

            //Agregar Roles
            var roles = new Roles[]{
                new Roles{Tipo="Personaje principal"},
                new Roles{Tipo="Personaje secundario"},
                new Roles{Tipo="Extra"},
                new Roles{Tipo="Doble de accion"},
                new Roles{Tipo="Cameo"},
            };
            foreach (Roles r in roles) contexto.Roless.Add(r);
            contexto.SaveChanges();

            //Agregar Generos
            var generosdpeliculas = new Generosdepeliculas[]{
                new Generosdepeliculas{Descripcion="Acción"}, 
                new Generosdepeliculas{Descripcion="Aventura"}, 
                new Generosdepeliculas{Descripcion="Comedia"}, 
                new Generosdepeliculas{Descripcion="Drama"}, 
                new Generosdepeliculas{Descripcion="Miedo"}, 
                new Generosdepeliculas{Descripcion="Ciencia Ficción"}, 
            };
            foreach (Generosdepeliculas g in generosdpeliculas) contexto.Generosdepeliculass.Add(g);
            contexto.SaveChanges();

            //Agregar Certificados
                var certificado = new CertificadosdePeliculas[]{
                    new CertificadosdePeliculas {Descripcion="AA"},
                    new CertificadosdePeliculas {Descripcion="A"},
                    new CertificadosdePeliculas {Descripcion="B"},
                    new CertificadosdePeliculas {Descripcion="B-15"},
                    new CertificadosdePeliculas {Descripcion="C"},
                    new CertificadosdePeliculas {Descripcion="D"},
                    new CertificadosdePeliculas {Descripcion="PG-13"},
                };
            foreach (CertificadosdePeliculas C in certificado) contexto.CertificadosdePeliculass.Add(C);
            contexto.SaveChanges();

            //Agregar Productores
            var productores = new Productores[]{
                new Productores{Nombre="Luis vo",email="luivui@gmail.com",SitioWeb="http://lv.com"},
                new Productores{Nombre="Fer ter",email="ferterrr@gmail.com",SitioWeb="http://fffeeerrr.com"},
                new Productores{Nombre="caro cama",email=" carrca@gmail.com",SitioWeb="http:// caro.com"},
            };
            foreach (Productores p in productores) contexto.Productoress.Add(p);
            contexto.SaveChanges();

            //Agregar Peliculas
            var pelicula = new Peliculas[]{
                new Peliculas{titulo= "el baleado",Historia="historia mexicana",FechaRealizada=DateTime.Parse("3/5/2004"),
                Duracion=120, GeneroId=generosdpeliculas.Single(g=>g.Descripcion=="Accion").GenerosId,
                CertificadoId=certificado.Single(c=>c.Descripcion=="PG-13").CertificadoId}  
            };
            foreach (Peliculas pl in pelicula) contexto.Peliculass.Add(pl);
            contexto.SaveChanges();
            //Agregar Roles de actores en peliculas
            var RolesdeActoresenP = new RolesdeActoresenPeliculas[]{
                new RolesdeActoresenPeliculas{PeliculaId=1, AutorId=2, RolId=3, Personaje="el sotelo",
                Descripcion=certificado.Single(c=>c.Descripcion=="PG-13").Descripcion,
                }
            };
            foreach (RolesdeActoresenPeliculas RA in RolesdeActoresenP) contexto.RolesdeActoresenPeliculass.Add(RA);
            contexto.SaveChanges();

            //Agregar Peliculas dirigidas por productores 
            var Peliculasdirigidasxproductores = new Peliculasdirigidasporproductores[]{
                new Peliculasdirigidasporproductores{ProductorId=100,
                PeliculaId=RolesdeActoresenP.Single(RA=>RA.PeliculaId==1).PeliculaId,
                }
            };
            foreach (Peliculasdirigidasporproductores RA in Peliculasdirigidasxproductores) contexto.Peliculasdirigidasporproductoress.Add(RA);
            contexto.SaveChanges();
            }
        }
    }
} 