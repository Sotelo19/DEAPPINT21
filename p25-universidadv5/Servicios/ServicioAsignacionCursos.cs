using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p21_universidadv1.Servicio {
    public class ServicioAsignacionCursos{
        private UniContexto contexto;
        public ServicioAsignacionCursos(UniContexto uniContexto) => contexto = uniContexto;
        
        public List<AsignacionCurso> ObtenerTodo() => 
            contexto.AsignacionCursos
            .Include(c=>c.Curso)
            .Include(i=>i.Instructor)
            .ToList();
        
        public AsignacionCurso Obtener(int Id1, int Id2) {
            AsignacionCurso asignacioncurso = 
                contexto.AsignacionCursos
                .FirstOrDefault(a=>a.CursoId.Equals(Id1)&&a.InstructorId.Equals(Id2));
            return asignacioncurso;
        }

        public bool Insertar(AsignacionCurso asignacioncurso) {
             try {
                contexto.AsignacionCursos.Add(asignacioncurso);
                contexto.SaveChanges();
             } catch(Exception) {

             }
            return true;
        }

        public bool Eliminar(AsignacionCurso asignacioncurso) {
            contexto.AsignacionCursos.Remove(asignacioncurso);
            contexto.SaveChanges();
            return true;
        }
    }
}