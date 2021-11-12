using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
 
namespace p21_universidadv1.Modelo
{
    public class Estudiante : Persona {
        [DataType(DataType.Date)]
        public DateTime FechadeIngreso {get; set;}

        public ICollection<Inscripcion> Inscripciones {get; set;}
    }
}