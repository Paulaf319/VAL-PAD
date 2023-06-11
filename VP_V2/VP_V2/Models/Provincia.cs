using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VP_V2.Models
{
    [Table("Provincias")]
    public class Provincia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProv { get; set; }
        [StringLength(50)]
        public string Nom_Prov { get; set; } = string.Empty;
    }
}
