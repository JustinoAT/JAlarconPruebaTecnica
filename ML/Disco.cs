using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ML
{
    public class Disco
    {
        [Required]
        public int IdDisco { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Artista { get; set; }
        [Required]
        public string GeneroMusical { get; set; }
        [Required]
        public string Duracion { get; set; }
        [Required]
        public DateTime Año { get; set; }
        [Required]
        public string Distribuidora { get; set; }
        [Required]
        public string Ventas { get; set; }
        [Required]
        public int Disponibilidad { get; set; }
        public List<object> Discos { get; set; }    




    }
}
