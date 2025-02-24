using System.ComponentModel.DataAnnotations;

namespace Deber.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [EmailAddress]
        public required string Correo { get; set; }

        [Phone]
        public required string Telefono { get; set; }

        public required string Direccion { get; set; }
    }
}
