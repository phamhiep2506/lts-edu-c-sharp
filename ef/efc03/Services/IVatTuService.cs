using efc03.Dtos;

namespace efc03.Services;

public interface IVatTuService
{
    public void ThemVatTu(VatTuDto vatTuDto);

    public int GetVatTuId(string tenVatTu);

    public int GetSoLuong(string tenVatTu);
}