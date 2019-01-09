namespace Firoozi.Repository.Data.EntityMappings
{
    using Firoozi.Domain;
    using System.Data.Entity.ModelConfiguration;

    public class EntityBaseConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.Id);
        }
    }
    public class EntityBaseConfiguration<TEntity, TKey> : EntityTypeConfiguration<TEntity> where TEntity : class, IEntity<TKey>
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.Id);
        }
    }
}
