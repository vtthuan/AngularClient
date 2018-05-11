namespace AngularClient.Models
{
    public interface IProvider
    {
        string Name { get; }
        string UrlPattern { get; }
        string Url { get; }
    }
}
