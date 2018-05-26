namespace AngularClient.Models.Steps
{
    public class PreViewStep : Step
    {
  
        public override string Action
        {
            get
            {
                return "PreviewStep";
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
                return "Mots clé";
            }
        }

        public override string Icon
        {
            get
            {
                return "glyphicon glyphicon-tags";
            }
        }

        public override int Order => 5;
    }
}