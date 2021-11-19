using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p21_universidadv1.Servicio {
    public class ServicioOficinaAsignadas {
        private UniContexto contexto;
        public ServicioOficinaAsignadas(UniContexto uniContexto) => contexto = uniContexto;
        public List<OficinaAsignada> ObtenerTodo() => 
            contexto.OficinaAsignadas
            .Include(i=>i.Instructor)
            .ToList();
        public OficinaAsignada Obtener(int Id) {
            OficinaAsignada oficinaasignada = 
                contexto.OficinaAsignadas.FirstOrDefault(e=>e.InstructorId.Equals(Id));
            return oficinaasignada;
        }
        public bool Insertar(OficinaAsignada oficinaasignada) {
            try {
                contexto.OficinaAsignadas.Add(oficinaasignada);
                contexto.SaveChanges();
            } catch(Exception) {
                
            }
            return true;
        }
        public bool Actualizar(OficinaAsignada oficinaasignada) {
            try {
            contexto.OficinaAsignadas.Update(oficinaasignada);
            contexto.SaveChanges();
            } catch(Exception) {
                
            }
            return true;
        }
        public bool Eliminar(OficinaAsignada oficinaasignada) {
            contexto.OficinaAsignadas.Remove(oficinaasignada);
            contexto.SaveChanges();
            return true;
        }
    }
}