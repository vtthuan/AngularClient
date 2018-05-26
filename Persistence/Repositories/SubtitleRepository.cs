using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using System.Linq;
namespace AngularClient.Persistence.Repositories
{
    public class SubtitleRepository : ISubtitleRepository
    {
        private readonly IApplicationDbContext _unit;
        public SubtitleRepository(IApplicationDbContext unit)
        {
            _unit = unit;
        }

        public Subtitle Get(int id)
        {
            return _unit.Subtitles.FirstOrDefault(x=>x.Id == id);
        }

        public Subtitle Get(Video video, Language language)
        {
            if (video == null && language == null)
                return null;
               
            return _unit.Subtitles
                .FirstOrDefault(x => x.Video.Id == video.Id && x.Language.Id == language.Id);
        }
    }
}