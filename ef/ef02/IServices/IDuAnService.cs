using ef02.Dto;

namespace ef02.IServices
{
    public interface IDuAnService
    {
        public void ThemDuAn(DuAnDto duAnDto);
        public void SuaDuAn(SuaDuAnDto suaDuAnDto);
    }
}
