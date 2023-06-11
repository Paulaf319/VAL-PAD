using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VP_V2.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCli { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre.")]
        [StringLength(50)]
        public string Nom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Se requiere un apellido.")]
        [StringLength(50)]
        public string Ape { get; set; } = string.Empty;
        [StringLength(10)]
        public string? Dni { get; set; }
        [StringLength(10)]
        public string? Cod_Tel { get; set; }
        [StringLength(10)]
        public string? Tel { get; set; }
        [StringLength(50)]
        public string? Mail { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Fecha_Baja { get; set; }
        //public Localidad Localidad { get; set; }
        //[ForeignKey("Usuario")]
        //public int UserId { get; set; }
        //public virtual Usuario Usuario { get; set; } = null!;
    }
}
