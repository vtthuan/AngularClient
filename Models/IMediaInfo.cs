namespace AngularClient.Models
{
    interface IMediaInfo
    {
        string VideoID { get; set; }
        int Duration { get; set; }
        int ViewCount { get; set; }
    }
}
