using ef03.Dto;
namespace ef03.IService;

public interface IHocVienService
{
    public void ThemHocVien(ThemHocVienDto themHocVienDto);

    public void SuaHocVien(SuaHocVienDto suaHocVienDto);
}