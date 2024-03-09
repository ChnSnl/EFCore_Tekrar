using EFCore_Tekrar.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Tekrar.Models.Configuration
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder); //configure metodunun orjinal görevi ve üzerine ek olarak aşşağıdakiler;
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
