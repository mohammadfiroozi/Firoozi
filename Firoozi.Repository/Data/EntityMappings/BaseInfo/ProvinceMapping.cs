using Firoozi.Domain;

namespace Firoozi.Repository.Data.EntityMappings
{
    public class ProvinceMapping : EntityBaseConfiguration<Province>
    {
        public ProvinceMapping()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.GeographicalLocation.Longitude).IsOptional();
            Property(c => c.GeographicalLocation.Latiude).IsOptional();
            Property(c => c.Code).IsOptional();
            HasMany(s => s.Cities).WithRequired(r => r.Province).HasForeignKey(r => r.Province_Id);
        }
    }
}
