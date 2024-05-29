using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace GestionProyectos.Shared.Entities
{
    public class PersonaE
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es obligatorio")]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int? TipoIdentificacion { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int? Cedula { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Contrasenia { get; set; }
    }
}
