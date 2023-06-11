using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VP_V2.Models
{
    [Table("Localidades")]
    public class Localidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoc { get; set; }
        [StringLength(10)]
        public string Cod_Postal { get; set; } = string.Empty;
        [StringLength(50)]
        public string Nom_Ciudad { get; set; } = string.Empty;
        public Provincia Provincia { get; set; } = null!;
    }
}
