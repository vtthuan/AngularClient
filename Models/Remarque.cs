namespace AngularClient.Models
{
    public class Remarque : UpdatableEntity
    {
        public int Identifier { get; set; }
        public string Key { get; set; }
        public string PhraseLearning { get; set; }
        public string PhraseNative { get; set; }
        public double Min { get; set; }

        //public int NativeLanguageId { get; set; }
        //public Language NativeLanguage { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }        
    }
}