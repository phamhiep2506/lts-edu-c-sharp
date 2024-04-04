using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("DuAn")]
    public class DuAnModel
    {
        [Key]
        public int DuAnId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public required string TenDuAn { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Moto { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? GhiChu { get; set; }

    }
}
