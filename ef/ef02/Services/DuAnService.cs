using ef02.Dto;
using ef02.Models;
using ef02.IServices;

namespace ef02.Services
{
    public class DuAnService : IDuAnService
    {
        private NhanVienContext nhanVienContext = new NhanVienContext();

        public void ThemDuAn(DuAnDto duAnDto)
        {
            DuAnModel duAnModel = new DuAnModel()
            {
                TenDuAn = duAnDto.TenDuAn
            };
            nhanVienContext.Add(duAnModel);
            nhanVienContext.SaveChanges();
        }

        public void SuaDuAn(SuaDuAnDto suaDuAnDto)
        {
            DuAnModel? result = nhanVienContext.DuAnModel?.SingleOrDefault(x => x.TenDuAn == suaDuAnDto.TenDuAnCu);
            if (result != null)
            {
                result.TenDuAn = suaDuAnDto.TenDuAnMoi;
                result.Moto = suaDuAnDto.Moto != null ? suaDuAnDto.Moto : null;
                result.GhiChu = suaDuAnDto.GhiChu != null ? suaDuAnDto.GhiChu : null;
                nhanVienContext.Update(result);
                nhanVienContext.SaveChanges();
            }
        }
    }
}
