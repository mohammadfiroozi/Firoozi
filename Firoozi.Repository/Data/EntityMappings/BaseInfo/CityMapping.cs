namespace Firoozi.Repository.Data.EntityMappings
{
    using Firoozi.Domain;
    public class CityMapping : EntityBaseConfiguration<City>
    {
        public CityMapping()
        {
            
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.GeographicalLocation.Longitude).IsOptional();
            Property(c => c.GeographicalLocation.Latiude).IsOptional();

            //HasOptional(m => m.Province).WithMany().HasForeignKey(m => m.Province_Id);

        }
    }
}
