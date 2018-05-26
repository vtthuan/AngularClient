using AngularClient.Core;
using AngularClient.Core.Repositories;
using AngularClient.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace AngularClient.Persistence.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly IApplicationDbContext _unit;
        public VideoRepository(IApplicationDbContext unit)
        {
            _unit = unit;
        }

        public IEnumerable<Video> GetVideos(bool actif = true)
        {
            return _unit.Videos.Where(x => x.Actif == actif);
        }

        public IEnumerable<Video> GetVideosByUser(string userId)
        {
            return Base().Where(p => p.UserId == userId);
        }

        public Video GetVideoByUser(string videoId, string userId)
        {
            return Base().FirstOrDefault(p => p.MediaInfo.VideoID == videoId && p.UserId == userId);
        }

        private IQueryable<Video> Base()
        {
            return _unit.Videos
                .Include(x => x.MediaInfo)
                .Include(x => x.Category)
                .Include(x => x.User)
                .Include(x => x.Subtitles)
                .Include(x => x.Subtitles.Select(r => r.Language))
                .Include(x => x.Remarques)
                .Include(x => x.Remarques.Select(r=>r.NativeLanguage));
        }

        public void Add(Video video)
        {
            _unit.Videos.Add(video);
        }

        public Video Get(int id, bool actif = true)
        {
            return Base()
                .FirstOrDefault(x => x.Id == id && x.Actif == actif);
        }

        public Video Get(string videoId, bool actif = true)
        {
            return Base()
                .FirstOrDefault(x => x.MediaInfo.VideoID == videoId && x.Actif == actif);
        }
    }
}