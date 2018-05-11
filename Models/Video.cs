using System.Collections.Generic;

namespace AngularClient.Models
{
    public class Video : UpdatableEntity
    {
        public string Description { get; set; }
        public bool Actif { get; set; }

        public int MediaInfoId { get; set; }
        public virtual MediaInfo MediaInfo { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual int Price { get; set; }

        //public int PostId { get; set; }
        //public Post Post { get; set; }

        public IList<Subtitle> Subtitles { get; set; }
        public ICollection<Remarque> Remarques { get; set; }

        //public ICollection<Question> Questions { get; set; }

        public Video()
        {
            Actif = false;
            Subtitles = new List<Subtitle>();
            //Questions = new List<Question>();
        }

    }
}