using FinSAD.Domain.Entities;
using AutoMapper;

namespace FinSAD.Application.DTOs
{
    public class FinanceReportDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Format { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class FinanceReportDtoProfile : Profile
    {
        public FinanceReportDtoProfile()
        {
            CreateMap<FinanceReport, FinanceReportDto>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.ToString("yyyy-MM-dd")));

        }
    }
}