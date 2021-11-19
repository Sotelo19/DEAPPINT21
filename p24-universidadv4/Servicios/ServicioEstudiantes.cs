using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;

namespace p21_universidadv1.Servicio {
    public class ServicioEstudiantes {
        private UniContexto contexto;
        public ServicioEstudiantes(UniContexto uniContexto) => contexto = uniContexto;
        public List<Estudiante> ObtenerTodo() => 
        contexto.Estudiantes
        .Include(i=>i.Inscripciones)
            .ThenInclude(c=>c.Curso)
        .ToList();
        public Estudiante Obtener(int Id) {
            Estudiante estudiante = contexto.Estudiantes.FirstOrDefault(e=>e.Id.Equals(Id));
            return estudiante;
        }
        public bool Insertar(Estudiante estudiante) {
            contexto.Estudiantes.Add(estudiante);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Estudiante estudiante) {
            contexto.Estudiantes.Update(estudiante);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Estudiante estudiante) {
            contexto.Estudiantes.Remove(estudiante);
            contexto.SaveChanges();
            return true;
        }
    }
}