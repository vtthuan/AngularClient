namespace AngularClient.Models.Steps
{
    public class SubtitleStep : Step
    {
       public override string Action
        {
            get
            {
                return "SubtitleStep";
            }
        }

        public override string Controller
        {
            get
            {
                return "Videos";
            }
        }

        public override string Name
        {
            get
            {
                return "Vidéo";
            }
        }

        public override string Icon
        {
            get
            {
                return "glyphicon glyphicon-subtitles";
            }
        }

        public override bool IsLastStep
        {
            get
            {
                return false; 
            }
        }

        public override int Order => 15;
    }
}