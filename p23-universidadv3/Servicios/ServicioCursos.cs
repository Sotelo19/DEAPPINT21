using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;

namespace p21_universidadv1.Servicio {
    public class ServicioCursos {
        private UniContexto contexto;
        public ServicioCursos(UniContexto uniContexto) => contexto = uniContexto;
        public List<Curso> ObtenerTodo() => contexto.
            Cursos.Include(d=>d.Departamento)
            .ToList();
        public Curso Obtener(int Id) {
            Curso curso = contexto
            .Cursos.Include(d=>d.Departamento)
            .FirstOrDefault(e=>e.CursoId.Equals(Id));
            return curso;
        }
        public bool Insertar(Curso curso) {
            contexto.Cursos.Add(curso);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Curso curso) {
            contexto.Cursos.Update(curso);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Curso curso) {
            contexto.Cursos.Remove(curso);
            contexto.SaveChanges();
            return true;
        }
    }
}