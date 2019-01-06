using Firoozi.Domain.BasicInfo;
using System.Collections.Generic;
using System.Linq;

namespace Firoozi.Repository.Data.Repository.Entities
{
    public class CountryRepository : Repository<Country>, ICountryRepository

    {
        public CountryRepository(FirooziDbContext context) : base(context)
        {
        }

        public FirooziDbContext FirooziContext
        {
            get { return _context as FirooziDbContext;}
        }
        public IEnumerable<Country> GetAllWithoutAbbrevation()
        {
           return FirooziContext.Countries.Where(c => c.Abbrevation != null).ToList();
        }
    }
}
