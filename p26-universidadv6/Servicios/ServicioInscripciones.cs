using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p21_universidadv1.Servicio {
    public class ServicioInscripciones {
        private UniContexto contexto;
        public ServicioInscripciones(UniContexto uniContexto) => contexto = uniContexto;
        
        public List<Inscripcion> ObtenerTodo() => 
            contexto.Inscripciones
            .Include(c=>c.Curso)
            .Include(e=>e.Estudiante)
            .ToList();

        public Inscripcion Obtener(int Id) {
            Inscripcion inscripcion = 
                contexto.Inscripciones.FirstOrDefault(e=>e.InscripcionId.Equals(Id));
            return inscripcion;
        }

        public bool Insertar(Inscripcion inscripcion) {
            contexto.Inscripciones.Add(inscripcion);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Inscripcion inscripcion) {
            contexto.Inscripciones.Update(inscripcion);
            contexto.SaveChanges();
            return true;
        }
        
        public bool Eliminar(Inscripcion inscripcion) {
            contexto.Inscripciones.Remove(inscripcion);
            contexto.SaveChanges();
            return true;
        }
    }
}