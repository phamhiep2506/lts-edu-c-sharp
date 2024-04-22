using System.Globalization;
using AutoMapper;
using wa.Models;
using wa.Models.Dtos.KhachHang;

namespace wa.Profiles;

public class KhachHangProfile : Profile
{
    public KhachHangProfile()
    {
        CreateMap<CreateKhachHangDto, KhachHang>()
            .ForMember(
                dest => dest.NgaySinh,
                source => source.MapFrom(s => stringToDateTime(s.NgaySinh))
            );

        CreateMap<KhachHang, GetKhachHangDto>()
            .ForMember(
                dest => dest.NgaySinh,
                source => source.MapFrom(s => dateTimeToString(s.NgaySinh))
            );
    }

    private DateTime stringToDateTime(string? s)
    {
        DateTime dateTime;
        bool isDateTime = DateTime.TryParseExact(
            s,
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out dateTime
        );
        if (!isDateTime)
        {
            return default;
        }
        return dateTime;
    }

    private string dateTimeToString(DateTime dateTime)
    {
        return dateTime.ToString("dd/MM/yyyy");
    }
}
