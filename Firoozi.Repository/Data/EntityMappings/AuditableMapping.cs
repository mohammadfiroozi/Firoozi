using Firoozi.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Firoozi.Repository.Data.EntityMappings
{
    public class AuditableMapping : EntityTypeConfiguration <AuditableEntity>
    {
        public AuditableMapping()
        {
            

        }

    }
}
