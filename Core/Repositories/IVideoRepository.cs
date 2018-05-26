using AngularClient.Models;
using System.Collections.Generic;

namespace AngularClient.Core.Repositories
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetVideos(bool actif = true);
        IEnumerable<Video> GetVideosByUser(string userId);
        Video GetVideoByUser(string videoId, string userId);
        Video Get(int id, bool actif = true);
        Video Get(string videoId, bool actif = true);

        void Add(Video video);
    }
}