using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("NhanVien")]
    public class NhanVienModel
    {
        [Key]
        public int NhanVienId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public required string HoTen { get; set; }

        public string? SoDienThoai { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? DiaChi { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }

        [Required]
        public required int HeSoLuong { get; set; }
    }
}
