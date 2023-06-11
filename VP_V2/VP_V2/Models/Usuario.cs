using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VP_V2.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre de usuario.")]
        [StringLength(50)]
        public string User { get; set; } = string.Empty;
        [Required(ErrorMessage = "Se requiere una contraseña.")]
        public string Pass { get; set; } = string.Empty;
        //[ForeignKey("Cliente")]
        //public int CliId { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
