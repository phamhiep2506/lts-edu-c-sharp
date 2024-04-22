using System.ComponentModel.DataAnnotations;

namespace wa.Models.Dtos.LoaiSanPham;

public class CreateLoaiSanPhamDto
{
    [MaxLength(50, ErrorMessage = "Tên loại sản phẩm không được quá 50 kí tự")]
    public string? TenLoaiSanPham { get; set; }
}
