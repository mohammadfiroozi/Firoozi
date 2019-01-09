/// <summary>
/// remove BasicInfo from namespace can improve code readability
/// </summary>
namespace Firoozi.Domain
{
    using Firoozi.Domain.ComplexTypes;
    using System.Collections.Generic;

    public class Country : Entity, IHaveCode, IHaveDescription
    {
        public string Abbrevation { get; set; }
        public string Name { get; set; }
        public GeographicalLocation GeographicalLocation { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// flag must be Flag
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// Hey Mohammad !!! look at this comment
        /// HashSet<T> vs List<T>
        /// In most cases you can add an item to the collection only once because for 
        /// example each status is applied only once to a content.Therefore HashSet
        /// is the correct data structure as it will prevent duplicates. 
        /// https://stackoverflow.com/questions/28672082/asp-net-entity-framework-6-hashset-or-list-for-a-collection
        /// </summary>
        #region Navigations
        public ICollection<Province> Provinces { get; set; } = new HashSet<Province>();
        #endregion
    }

}
