
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using p21_universidadv1.Modelo;

namespace p21_universidadv1.Data
{
    public class UniContexto : DbContext {
        public UniContexto(DbContextOptions<UniContexto> opciones) : base(opciones) {

        }
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Departamento> Departamentos {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Inscripcion> Inscripciones {get; set;}
        public DbSet<Instructor> Instructores {get; set;}
        public DbSet<OficinaAsignada> OficinaAsignadas {get; set;}
        public DbSet<AsignacionCurso> AsignacionCursos {get; set;}

        // Api fluida
        protected override void OnModelCreating(ModelBuilder mod) {
            mod.Entity<AsignacionCurso>().HasKey(k=>new {k.CursoId,k.InstructorId});
        }
    }
}