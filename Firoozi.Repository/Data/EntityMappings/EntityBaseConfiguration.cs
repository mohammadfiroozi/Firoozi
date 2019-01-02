using System.Data.Entity.ModelConfiguration;

namespace Firoozi.Repository.Data.EntityMappings
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntity<int>
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.Id);

           
        }
    }
}
