using System.Collections.Generic;

namespace AngularClient.ViewModel
{
    public class RemarqueViewModel
    {
        public int Identifier { get; set; }
        public string Key { get; set; }
        public string PhraseLearning { get; set; }
        public string PhraseNative { get; set; }
        public double Min { get; set; }
    }

    public class RemarqueCreateViewModel : RemarqueViewModel
    {
        private bool _show;
        public bool Show {
            get { return _show; }
            set
            {
                _show = value;
                ButtonText = _show ? "Modifier" : "Ajouter";
            }
        }

        public string ButtonText { get; set; }

        public RemarqueCreateViewModel()
        {
            ButtonText = _show ? "Modifier" : "Ajouter";
        }
    }

    public class RemarquesCreateViewModel
    {        
        public string VideoId { get; set; }
        public string NativeLanguageCode { get; set; }
        public int NativeRemarqueCount { get; set; }
        public List<RemarqueCreateViewModel> Remarques { get; set; }
    }
}