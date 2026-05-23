using System.ComponentModel.DataAnnotations;

namespace Contactos.SI.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }
    }
}
