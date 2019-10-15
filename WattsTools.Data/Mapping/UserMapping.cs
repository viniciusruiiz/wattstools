using FluentNHibernate.Mapping;
using WattsTools.Domain.Entity;

namespace WattsTools.Data.Mapping
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Table("USUARIO");
            Id(m => m.Id).Column("USUARIO_CODE");

            Map(m => m.Email).Length(120).Not.Nullable().Unique().Column("USUARIO_EMAIL");
            Map(m => m.Name).Length(60).Column("USUARIO_NAME");
            HasManyToMany(x => x.Products)
               .Cascade.All()
               .Table("USUARIO_PRODUCT");
        }
    }
}

