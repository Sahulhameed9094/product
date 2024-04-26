using HolaHealth.Suite.ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HolaHealth.Suite.ProductService;

public abstract class ProductServiceController : AbpController
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
