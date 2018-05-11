namespace AngularClient.Models
{
    public abstract class MediaProvider : Entity, IProvider
    {
        public abstract string Name { get; }
        public abstract string UrlPattern { get; }
        public abstract string Url { get; }
    }
}