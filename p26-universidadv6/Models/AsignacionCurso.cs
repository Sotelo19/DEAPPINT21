namespace p21_universidadv1.Modelo
{
    public class AsignacionCurso {
        public int InstructorId {get; set;}
        public int CursoId {get; set;}

        public Curso Curso {get; set;}
        public Instructor Instructor {get; set;}
    }
}