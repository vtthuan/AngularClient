namespace AngularClient.Models.Steps
{
    public interface IStep
    {
        string Name { get; }
        string Action { get; }
        string Icon { get; }
        string Controller { get; }
    }
}
