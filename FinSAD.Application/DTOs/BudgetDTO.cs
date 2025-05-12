using FinSAD.Domain.Entities;
using AutoMapper;

namespace FinSAD.Application.DTOs
{
    public class BudgetDto
    {
        public int Id { get; set; }
        public string Limit { get; set; }
        public int UserId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int? CategoryId { get; set; }
    }

    public class BudgetDtoProfile : Profile
    {
        public BudgetDtoProfile()
        {
            CreateMap<Budget, BudgetDto>()
                .ForMember(dest => dest.Limit, opt => opt.MapFrom(src => src.Limit.ToString()));
        }
    }
}