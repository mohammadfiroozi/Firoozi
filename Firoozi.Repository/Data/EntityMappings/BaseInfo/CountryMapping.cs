namespace Firoozi.Repository.Data.EntityMappings
{
  using Firoozi.Domain;  
    public class CountryMapping : EntityBaseConfiguration<Country>
    {
        public CountryMapping()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.Abbrevation).IsOptional().HasMaxLength(5);
            Property(c => c.Code).IsOptional();
            Property(c => c.Flag).IsOptional();
            HasMany(s => s.Provinces).WithRequired(r => r.Country).HasForeignKey(r => r.Country_Id);
        }
    }
}
