namespace AngularClient.Models
{
    public class DailyMotionMediaInfo : MediaInfo
    {
        public override string PatternUrl
        {
            get { return @"http://www.dailymotion.com/video/{0}"; }
        }

        public override string ThumbnailPatternUrl
        {
            get { return @"http://www.dailymotion.com/thumbnail/video/{0}"; }
        }
    }
}