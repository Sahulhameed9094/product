using HolaHealth.Suite.ProductService.Localization;
using Volo.Abp.Application.Services;

namespace HolaHealth.Suite.ProductService;

public abstract class ProductServiceAppService : ApplicationService
{
    protected ProductServiceAppService()
    {
        LocalizationResource = typeof(ProductServiceResource);
        ObjectMapperContext = typeof(ProductServiceApplicationModule);
    }
}
