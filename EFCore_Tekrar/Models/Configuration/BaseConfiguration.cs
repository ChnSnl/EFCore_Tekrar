using EFCore_Tekrar.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Tekrar.Models.Configuration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) //bu metodu farklı classlarda kullanmak isteyebileceğimiz için polymorphism uygulayıp virtual yapıyoruz.
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
        }
    }
}
