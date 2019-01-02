using System.Collections.Generic;

namespace Firoozi.Domain.BasicInfo
{
    public class Country : Entity<int>
    {
        public string Abbrevation { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public int PhoneCode { get; set; }
        public string flag { get; set; }

        #region Navigations
        public ICollection<Province> Provinces { get; set; }
        #endregion

        public Country()
        {
            Provinces = new List<Province>();
        }
    }

}
