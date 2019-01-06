using Firoozi.Domain.BasicInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Firoozi.Repository.Data.Repository
{
   public interface ICountryRepository :IRepository<Country>
    {
        IEnumerable<Country> GetAllWithoutAbr();
    }

    public class CountryRepository : Repository<Country>, ICountryRepository

    {
        public CountryRepository(FirooziDbContext context) : base(context)
        {
        }

        public FirooziDbContext FirooziContext
        {
            get { return Context as FirooziDbContext; }
        }
        public IEnumerable<Country> GetAllWithoutAbr()
        {
            throw new NotImplementedException();
        }
    }
}
