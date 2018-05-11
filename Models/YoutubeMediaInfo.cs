namespace AngularClient.Models
{
    public class YoutubeMediaInfo : MediaInfo
    {
        public override string ThumbnailPatternUrl
        {
            get { return @"https://img.youtube.com/vi/{0}/maxresdefault.jpg"; }
        }

        public override string PatternUrl {
            get { return @"https://www.youtube.com/watch?v={0}&cc_load_policy=0&controls=0"; }
        }
    }
}