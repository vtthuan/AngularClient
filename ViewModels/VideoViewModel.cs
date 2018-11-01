using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularClient.ViewModel
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public string DateCreated { get; set; }

        public string CodeNative { get; set; }
        public string CodeLearning { get; set; }

        public string SubtitlePathNative { get; set; }
        public string SubtitlePathLearning { get; set; }
        public string Title { get; set; }
        public string ViewCount { get; set; }
        public string Duration { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        [Required]
        [Display(Name = "Vidéo")]
        public string VideoId { get; set; }
    }

    //public class VideoCreateViewModel
    //{
    //    public List<SubtitleCreateViewModel> Subtitles { get; set; }
    //    public VideoCreateViewModel()
    //    {
    //        Subtitles = new List<SubtitleCreateViewModel>();
    //    }
    //    public VideoViewModel VideoViewModel { get; set; }
    //    [Display(Name = "Terms et Conditions")]
    //    [Range(typeof(bool), "false", "false", ErrorMessage = "Acceptez la condition svp!")]
    //    public bool TermsAndConditions { get; set; }
    //}
}