namespace Firoozi.Domain.BasicInfo
{
    public class City : Entity<int>
    {
        
        public string Name { get; set; }
        public float Latiude { get; set; }
        public float longitude { get; set; }
        public int Province_Id { get; set; }
        #region Navigations
        public virtual Province Province { get; set; }
        #endregion

    }

}
