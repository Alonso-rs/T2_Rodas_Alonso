using System.ComponentModel.DataAnnotations;

namespace T2_Rodas_Alonso.Models
{
    public class Distribuidor
    {

        public int Id { get; set; }

        [Required]
        public string NombreDistribuidor { get; set; }

        [Required]
        public string RazonSocial { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        [Range(1900, 3000)]
        public int AnioInicioOperacion { get; set; }

        [Required]
        public string Contacto { get; set; }
    }
}

