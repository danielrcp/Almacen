using System.ComponentModel.DataAnnotations;

namespace Almacen.Web.Models
{
    public class Persona
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un nombre")]
        [NombreValido(ErrorMessage = "El nombre {0} ya existe")]
        public string Nombre { get; set; }
        [StringLength(5,MinimumLength =5,ErrorMessage ="El código postal debe ser de mínimo 5 caracteres")]
        public int CodigoPostal { get; set; }
        [Range(0,100)]
        public byte DominioIngles { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un correo")]
        [RegularExpression(@".+\@.+\..+")]
        public string Correo { get; set; }
        [Required]
        public string[] Habilidades { get; set; }
    }
}
