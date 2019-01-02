using System;

namespace Firoozi.Domain
{
    public interface IAuditableEntity
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedUser { get; set; }
        string ModifiedUser { get; set; }
        string IPAddress { get; set; }
    }
}
