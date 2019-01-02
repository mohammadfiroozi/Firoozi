using Firoozi.Domain.BasicInfo;

namespace Firoozi.Repository.Data.EntityMappings.BaseInfo
{
    public class CityMapping : EntityBaseConfiguration<City>
    {
        public CityMapping()
        {
            
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.longitude).IsOptional();
            Property(c => c.Latiude).IsOptional();

            //HasOptional(m => m.Province).WithMany().HasForeignKey(m => m.Province_Id);

        }
    }
}
