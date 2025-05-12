using FinSAD.Domain.Entities;
using AutoMapper;

namespace FinSAD.Application.DTOs
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Name { get; set; }
        public string TransactionKind { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int UserId { get; set; }
        public int? PaymentMethodId { get; set; }
        public string Location { get; set; }
    }

    public class TransactionDtoProfile : Profile
    {
        public TransactionDtoProfile()
        {
            CreateMap<Transaction, TransactionDto>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.ToString()))
                .ForMember(dest => dest.TransactionKind, opt => opt.MapFrom(src => src.TransactionKind.ToString()));
        }
    }
}