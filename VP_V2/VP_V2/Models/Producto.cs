using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VP_V2.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProd { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre o descripcion.")]
        [StringLength(50)]
        public string Desc_Prod { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,4)")]
        public decimal Precio_Costo { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Precio_Venta { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Baja { get; set; }
    }
}
