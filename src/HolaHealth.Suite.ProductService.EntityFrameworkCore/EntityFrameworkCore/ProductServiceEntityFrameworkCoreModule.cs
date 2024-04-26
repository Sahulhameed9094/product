using Microsoft.Extensions.DependencyInjection;
using HolaHealth.Suite.ProductService.Products;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Modularity;
using Volo.Abp.Timing;
using System;

namespace HolaHealth.Suite.ProductService.EntityFrameworkCore;

[DependsOn(
    typeof(AbpEntityFrameworkCorePostgreSqlModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(ProductServiceDomainModule)
)]
public class ProductServiceEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        ProductServiceEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ProductServiceDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
            options.AddRepository<Product, EfCoreProductRepository>();
        });

        Configure<AbpDbContextOptions>(options =>
        {
            options.Configure<ProductServiceDbContext>(c =>
            {
                c.UseNpgsql(b =>
                {
                    b.MigrationsHistoryTable("__ProductService_Migrations");
                });
            });
        });


        Configure<AbpClockOptions>(options => { options.Kind = DateTimeKind.Utc; });
    }
}
