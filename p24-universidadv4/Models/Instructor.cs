using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace p21_universidadv1.Modelo
{
    public class Instructor : Persona {
        [DataType(DataType.Date)]
        public DateTime FechaContratacion {get; set;}

        public ICollection<AsignacionCurso> AsignacionCursos {get; set;}
        public OficinaAsignada OficinaAsignada {get; set;}
    }
}