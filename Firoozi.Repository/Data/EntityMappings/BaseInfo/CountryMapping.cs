using Firoozi.Domain.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firoozi.Repository.Data.EntityMappings.BaseInfo
{
    public class CountryMapping : EntityBaseConfiguration<Country>
    {
        public CountryMapping()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.Abbrevation).IsOptional().HasMaxLength(5);
            Property(c => c.NickName).IsOptional().HasMaxLength(200);
            Property(c => c.PhoneCode).IsOptional();
            Property(c => c.flag).IsOptional();
            HasMany(s => s.Provinces).WithRequired(r => r.Country).HasForeignKey(r => r.Country_Id);
        }
    }
}
