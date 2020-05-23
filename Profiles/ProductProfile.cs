using AutoMapper;
using productAPI.DTOs;
using productAPI.Models;

namespace productAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductModel, ProductReadDTO>();
            CreateMap<ProductCreateDTO, ProductModel>();
            CreateMap<ProductUpdateDTO, ProductModel>();
        }
    }
}