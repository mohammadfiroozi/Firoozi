namespace Firoozi.Domain
{
    using System;
    public abstract class AuditableEntity : IAuditableEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }
        public string IPAddress { get; set; }
    }
}
