namespace Firoozi.Domain
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
