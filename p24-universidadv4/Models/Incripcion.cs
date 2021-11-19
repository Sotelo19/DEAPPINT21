using System;
using System.ComponentModel.DataAnnotations;
namespace p21_universidadv1.Modelo
{
    public class Inscripcion {
        [Key]
        public int InscripcionId {get; set;}
        public int CursoId {get; set;}
        public int EstudianteId {get; set;}
        [DisplayFormat(NullDisplayText="Sin Calificar")]
        public float? Promedio {get; set;}

        public Curso Curso {get; set;}
        public Estudiante Estudiante {get; set;}
    }
}