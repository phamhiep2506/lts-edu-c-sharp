using ef05.Dtos;

namespace ef05.Services;

public interface ICongThucService
{
    public void ThemCongThuc(List<ThemCongThucDto> themCongThucDto);
}