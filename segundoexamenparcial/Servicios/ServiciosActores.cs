using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServiciosActores {
        private DvdContexto contexto;
        public ServiciosActores(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Actores> ObtenerTodo(string cadenabuscar)  {
            var _Actoress = contexto.
            Actoress.Include(d=>d.Rolesdeactoresenpeliculass);

            var Actoress = from c in _Actoress select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Actoress = Actoress.Where(c=>c.Nombre.Contains(cadenabuscar));
            }
            return Actoress.ToList();
        }

        public Actores Obtener(int Id) {
            Actores Actores = contexto
            .Actoress.Include(d=>d.Rolesdeactoresenpeliculass)
            .FirstOrDefault(e=>e.ActorId.Equals(Id));
            return Actores;
        }
        public bool Insertar(Actores Actores) {
            contexto.Actoress.Add(Actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Actores Actores) {
            contexto.Actoress.Update(Actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Actores Actores) {
            contexto.Actoress.Remove(Actores);
            contexto.SaveChanges();
            return true;
        }
    }
}