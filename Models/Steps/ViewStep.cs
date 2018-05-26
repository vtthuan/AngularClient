namespace AngularClient.Models.Steps
{
    public class ViewStep : Step
    {
        public override string Action
        {
            get
            {
                return "ViewStep";
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
                return "Video";
            }
        }

        public override string Icon
        {
            get
            {
                return "glyphicon glyphicon-facetime-video";
            }
        }

        public override int Order => 10;
    }
}