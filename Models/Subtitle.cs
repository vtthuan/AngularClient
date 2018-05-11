using System.Collections.Generic;
using System.IO;

namespace AngularClient.Models
{
    public class Subtitle : UpdatableEntity
    {
        public int VideoId { get; set; }
        public Video Video { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public string FilePath { get; set; }

        public Subtitle()
        {
            
        }

        public Subtitle(string filePath, Language lang)
        {
            FilePath = filePath;
            Language = lang;
        }
    }
}