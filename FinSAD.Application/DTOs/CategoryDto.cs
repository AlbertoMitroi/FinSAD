using AutoMapper;
using FinSAD.Domain.Entities;

namespace FinSAD.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCustom { get; set; }
    }

    public class CategoryDtoProfile : Profile
    {
        public CategoryDtoProfile()
        {
                CreateMap<Category, CategoryDto>();
        }
    }
}
