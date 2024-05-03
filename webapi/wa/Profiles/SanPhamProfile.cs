using AutoMapper;
using wa.Helpers;
using wa.Models;
using wa.Models.Dtos.SanPham;

namespace wa.Profiles;

public class SanPhamProfile : Profile
{
    public SanPhamProfile()
    {
        CreateMap<CreateSanPhamDto, SanPham>()
            .ForMember(
                dest => dest.NgayHetHan,
                source =>
                    source.MapFrom(s =>
                        DateTimeConvert.stringToDateTime(s.NgayHetHan)
                    )
            );
        CreateMap<SanPham, GetSanPhamDto>()
            .ForMember(
                dest => dest.NgayHetHan,
                source =>
                    source.MapFrom(s =>
                        DateTimeConvert.dateTimeToString(s.NgayHetHan)
                    )
            );
    }
}
