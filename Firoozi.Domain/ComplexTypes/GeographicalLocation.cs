namespace Firoozi.Domain.ComplexTypes
{
    ///
    /// Hey Mohammad !!!
    /// using the 'using' inside the 'namespace' can be more safe 
    /// in a way that you can be sure that no other 
    /// library can hijack a namespace and break your code. 
    /// https://patrickdesjardins.com/blog/c-using-statement-inside-or-outside-the-class-namespace
    ///
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class GeographicalLocation
    {
        public float Latiude { get; set; }
        public float Longitude { get; set; }
    }
}
