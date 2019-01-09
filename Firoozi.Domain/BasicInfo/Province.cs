namespace Firoozi.Domain
{
    using Firoozi.Domain.ComplexTypes;
    using System.Collections.Generic;

    public class Province : Entity, IHaveCode
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public GeographicalLocation GeographicalLocation { get; set; }
        public int Country_Id { get; set; }
        #region Navigations
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
        #endregion
    }

}
