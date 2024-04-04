using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("PhanCong")]
    public class PhanCongModel
    {
        [Key]
        public int PhanCongId { get; set; }

        public int NhanVienId { get; set; }

        public int DuAnId { get; set; }

        public int SoGioLam { get; set; }

        public NhanVienModel? NhanVienModel { get; set; }

        public DuAnModel? DuAnModel { get; set; }
    }
}
