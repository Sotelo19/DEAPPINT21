using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Certificadosdepeliculas {
        [Key]
        public int IdCertificado {get; set;}
        [Required]
        public string Certificado {get; set;}
    
    public ICollection<Peliculas> Peliculas {get; set;}
    }
}
