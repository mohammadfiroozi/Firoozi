using Firoozi.Domain;
using Firoozi.Repository.Data.EntityMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firoozi.Repository.Data
{
    public class FirooziDbContext : DbContext
    {
        public FirooziDbContext() : base("FirooziConnectionString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryMapping());
            modelBuilder.Configurations.Add(new ProvinceMapping());
            modelBuilder.Configurations.Add(new CityMapping());
        }
     
        #region Entites DBSet
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
       
        #endregion
    }
}
