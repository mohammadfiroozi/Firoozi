namespace Firoozi.Domain
{
    using Firoozi.Domain.ComplexTypes;

    public class City : Entity, IHaveCode
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public int Province_Id { get; set; }
        public GeographicalLocation GeographicalLocation { get; set; }
        #region Navigations
        public Province Province { get; set; }
        #endregion
    }

}
