using EFCore_Tekrar.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Tekrar.Models.Configuration
{
    public class AppUserConfiguration: BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID); //HasForeignkey ile ne tarafın null olabiliri bildiriyoruz
        }
    }
}
