namespace Firoozi.Domain
{
    /// <summary>
    /// Entity <<<< Entity<int>
    /// </summary>
    public class Entity : Entity<int> { }

    public abstract class Entity<T> : IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
