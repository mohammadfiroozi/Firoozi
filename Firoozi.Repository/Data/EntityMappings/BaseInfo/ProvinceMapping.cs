using Firoozi.Domain.BasicInfo;

namespace Firoozi.Repository.Data.EntityMappings.BaseInfo
{
    public class ProvinceMapping : EntityBaseConfiguration<Province>
    {
        public ProvinceMapping()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.longitude).IsOptional();
            Property(c => c.latitude).IsOptional();
            Property(c => c.PhoneCode).IsOptional();
            HasMany(s => s.Cities).WithRequired(r => r.Province).HasForeignKey(r => r.Province_Id);
        }
    }
}
