using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class Persona {
        [Key]
        public int Id {get; set;}
        [Required(ErrorMessage="Se requiere Apeido Paterno"), StringLength(50,ErrorMessage = "Longitud Maxima 50")]
        public string Apaterno {get; set;}
        [Required(ErrorMessage="Se requiere Apeido Materno"), StringLength(50,ErrorMessage = "Longitud Maxima 50")]
        public string Amaterno {get; set;}
        [Required(ErrorMessage="Se requiere Nombre"), StringLength(50,ErrorMessage = "Longitud Maxima 50")]
        public string Nombre {get; set;}
        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string Email {get; set;}
        public string NombreCompleto {
            get {
                return $"{Apaterno} {Amaterno} {Nombre}";
            }
        }
    }
}
 