namespace AngularClient.Models
{
    public abstract class MediaInfo : UpdatableEntity, IMediaInfo
    {
        public virtual string VideoID { get; set; }
        public abstract string PatternUrl { get; }
        public abstract string ThumbnailPatternUrl { get; }
        public int Duration { get; set; }
        public int ViewCount { get; set; }
        public string Title { get; set; }

        public string GetVideoUrl()
        {
            return string.Format(PatternUrl, VideoID);
        }

        public string GetThumbnailUrl()
        {
            return string.Format(ThumbnailPatternUrl, VideoID);
        }
    }
}