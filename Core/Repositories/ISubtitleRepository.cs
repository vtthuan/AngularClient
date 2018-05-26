using AngularClient.Models;

namespace AngularClient.Core.Repositories
{
    public interface ISubtitleRepository
    {
        
        Subtitle Get(int id);

        Subtitle Get(Video video, Language language);
    }
}
