using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef01.Models
{
    public class HocSinh
    {
        [Key]
        public int HocSinhID { get; set; }

        public int LopID { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public required string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? QueQuan { get; set; }

        public Lop? Lop { get; set; }
    }
}
