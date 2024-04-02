using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef01.Models
{
    public class Lop
    {
        [Key]
        public int LopID { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public required string TenLop { get; set; }

        public int SiSo { get; set; }
    }
}
