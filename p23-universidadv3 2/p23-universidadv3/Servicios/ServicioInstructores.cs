using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;

namespace p21_universidadv1.Servicio {
    public class ServicioInstructores {
        private UniContexto contexto;
        public ServicioInstructores(UniContexto uniContexto) => contexto = uniContexto;
        public List<Instructor> ObtenerTodo() => 
            contexto.Instructores
            .Include(o=>o.OficinaAsignada)
            .Include(a=>a.AsignacionCursos)
                .ThenInclude(c=>c.Curso)
            .ToList();
        public Instructor Obtener(int Id) {
            Instructor instructor = contexto.Instructores.FirstOrDefault(e=>e.Id.Equals(Id));
            return instructor;
        }
        public bool Insertar(Instructor instructor) {
            contexto.Instructores.Add(instructor);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Instructor instructor) {
            contexto.Instructores.Update(instructor);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Instructor instructor) {
            contexto.Instructores.Remove(instructor);
            contexto.SaveChanges();
            return true;
        }
    }
}