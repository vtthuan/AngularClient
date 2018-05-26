namespace AngularClient.Models
{
    public class Word : UpdatableEntity
    {
        public string Text { get; set; }
        public string Lemme { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Form { get; set; }
        public bool IsLem { get; set; }
        public string PossibleTypes { get; set; }
        public string Number { get; set; }
    }
}