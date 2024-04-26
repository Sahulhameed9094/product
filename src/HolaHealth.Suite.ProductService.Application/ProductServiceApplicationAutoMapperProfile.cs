using AutoMapper;
using HolaHealth.Suite.ProductService.Products;

namespace HolaHealth.Suite.ProductService;

public class ProductServiceApplicationAutoMapperProfile : Profile
{
    public ProductServiceApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>().MapExtraProperties();
    }
}
