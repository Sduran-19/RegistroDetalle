using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle.Models
{
    public class Sistemas
    {
        [Key]
        public int SistemaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Nombre { get; set; }
    }
}
