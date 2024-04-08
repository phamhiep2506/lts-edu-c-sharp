using efc03.Dtos;
using efc03.Models;

namespace efc03.Services;

public class VatTuService : IVatTuService
{
    private VatTuDbContext _context;

    public VatTuService()
    {
        _context = new VatTuDbContext();
    }

    public void ThemVatTu(VatTuDto vatTuDto)
    {
        VatTu vatTu = new VatTu()
        {
            TenVatTu = vatTuDto.TenVatTu,
            SoLuongTon = vatTuDto.SoLuongTon
        };
        _context.Add(vatTu);
        _context.SaveChanges();
    }

    public int GetSoLuong(string tenVatTu)
    {
        int getSoLuong = _context
            .VatTu
            .Where(x => x.TenVatTu == tenVatTu)
            .Select(x => x.SoLuongTon)
            .SingleOrDefault();
        return getSoLuong;
    }

    public int GetVatTuId(string tenVatTu)
    {
        int vatTuId = _context
            .VatTu
            .Where(x => x.TenVatTu == tenVatTu)
            .Select(x => x.VatTuId)
            .SingleOrDefault();
        return vatTuId;
    }

    public void HienVatTu()
    {
        List<VatTuDto> vatTuDtos = _context
            .VatTu
            .Select(x => new VatTuDto {
                TenVatTu = x.TenVatTu,
                SoLuongTon = x.SoLuongTon
            }).ToList();

        vatTuDtos.ForEach(x => {
            string msgSLTK = x.SoLuongTon == 0 ? "Het Hang" : x.SoLuongTon.ToString();
            Console.WriteLine($"{x.TenVatTu} - SLTK: {msgSLTK}");
        });
    }
}