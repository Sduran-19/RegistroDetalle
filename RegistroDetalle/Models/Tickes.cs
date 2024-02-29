using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroDetalle.Models
{
	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		[Required(ErrorMessage = "El campo fecha es obligatorio")]
		public DateTime Fecha { get; set; }

		public int PrioridadId { get; set; }

		public int ClienteId { get; set; }

		public int SistemaId { get; set; }

		[Required(ErrorMessage = "El campo solicitado por es obligatorio")]
		[RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Solo debe contener letras")]
		public string? Solicitadopor { get; set; }

		[Required(ErrorMessage = "El campo asunto es obligatorio")]
		public string? Asunto { get; set; }

		[Required(ErrorMessage = "El campo descripción es obligatorio")]
		public string? Descripcion { get; set; }
	}
}
