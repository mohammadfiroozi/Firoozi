using System.Collections.Generic;

namespace Firoozi.Domain.BasicInfo
{
    public class Province : Entity<int>
    {
      
        public string Name { get; set; }
        public int PhoneCode { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int Country_Id { get; set; }
        #region Navigations
        public virtual Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        #endregion

        public Province()
        {
            Cities = new List<City>();
        }

    }

}
