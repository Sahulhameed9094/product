using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace HolaHealth.Suite.ProductService.Products
{
    public class ProductCache
    {
        public virtual Guid? TenantId { get; protected set; }

        public virtual string Name { get; protected set; } = default!;

        public virtual float Price { get; set; }
    }
}
