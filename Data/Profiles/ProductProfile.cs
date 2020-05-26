using AutoMapper;
using productAPI.DTOs;
using productAPI.Models;

namespace productAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductModel, ProductDTO>();
            CreateMap<CreateProductRequest, ProductModel>();
            CreateMap<UpdateProductRequest, ProductModel>();
        }
    }
}