using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServiciosRoles {
        private DvdContexto contexto;
        public ServiciosRoles(DvdContexto DVdContexto) => contexto = DVdContexto;

        public List<Actores> ObtenerTodo(string cadenabuscar)  {
            var _Actores = contexto.
            Actores.Include(d=>d.Rolesdeactoresenpeliculass);

            var Actores = from c in _Actores select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Actores = Actores.Where(c=>c.Nombre.Contains(cadenabuscar));
            }
            return Actoress.ToList();
        }

        public Actores Obtener(int Id) {
            Actores Actores = contexto
            .Actores.Include(d=>d.Rolesdeactoresenpeliculass)
            .FirstOrDefault(e=>e.ActorId.Equals(Id));
            return Actores;
        }
        public bool Insertar(Actores Actores) {
            contexto.Actores.Add(Actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Actores Actores) {
            contexto.Actores.Update(Actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Actores Actores) {
            contexto.Actores.Remove(Actores);
            contexto.SaveChanges();
            return true;
        }
    }
}