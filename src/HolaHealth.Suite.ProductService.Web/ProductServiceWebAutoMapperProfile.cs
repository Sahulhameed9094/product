using AutoMapper;
using HolaHealth.Suite.ProductService.Products;

namespace HolaHealth.Suite.ProductService.Web;

public class ProductServiceWebAutoMapperProfile : Profile
{
    public ProductServiceWebAutoMapperProfile()
    {
        CreateMap<ProductDto, ProductUpdateDto>().MapExtraProperties();
    }
}
