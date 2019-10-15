using FluentNHibernate.Mapping;
using WattsTools.Domain.Entity;

namespace WattsTools.Data.Mapping
{
    public class ProductMapping : ClassMap<Service>
    {
        public ProductMapping()
        {
            Table("PRODUCT");
            Id(m => m.Id).Column("PRODUCT_ID");

            Map(m => m.Name).Column("PRODUCT_NAME");
            Map(m => m.Price).Column("PRODUCT_PRICE");
            HasManyToMany(x => x.Users)
               .Cascade.All()
               .Inverse()
               .Table("USUARIO_PRODUCT");
        }
    }
}
