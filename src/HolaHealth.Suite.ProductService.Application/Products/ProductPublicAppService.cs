using HolaHealth.Suite.ProductService.Permissions;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolaHealth.Suite.ProductService.Products;

[Authorize(ProductServicePermissions.Products.Default)]

public class ProductPublicAppService : ProductServiceAppService, IProductPublicAppService
{
    private readonly IProductRepository _productRepository;

    public ProductPublicAppService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public virtual async Task<List<ProductDto>> GetListAsync()
    {
        return ObjectMapper.Map<List<Product>, List<ProductDto>>(await _productRepository.GetListAsync());
    }
}
