using System.Collections.Generic;
using System.Linq;
using AngularClient.Models.Steps;

namespace AngularClient.ViewModel
{
    public class TransactionIndexViewModel
    {
        public string Duration { get; set; }
        public string VideoId { get; set; }
        public bool ShowAccessLink { get; set; }
        public bool ShowResumeLink { get; set; }
        public bool ShowRestartLink { get; set; }
        public string Notification { get; set; }
        public string Message { get; set; }
    }

    public class StepViewModel
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
    }

    public abstract class StepTransactionViewModel
    {
        public virtual IEnumerable<StepViewModel> Steps { get; set; }
        
        public StepViewModel CurrentStep
        {
            get
            {
                return Steps.ElementAt(CurrentStepIndex);
            }
        }
        
        /// <summary>
        /// index of transaction's steps 
        /// </summary>
        public int CurrentStepIndex { get; set; }

        public string Token { get; set; }

        public VideoViewModel Video { get; set; }
    }

    public class PreviewStepTransactionViewModel : StepTransactionViewModel
    { 
        public bool ShowNextForm { get; set; }
        
        public IList<RemarqueViewModel> Remarques { get; set; }
    }

    public class ViewStepTransactionViewModel : StepTransactionViewModel
    {
        public bool ShowNextForm { get; set; }
        public IList<RemarqueViewModel> Remarques { get; set; }
    }

    public class SubtitleStepTransactionViewModel : StepTransactionViewModel
    {
        public bool ShowNextForm { get; set; }
    }

    //public class ExerciseStepTransactionViewModel : StepTransactionViewModel
    //{
    //    public IList<QuestionViewModel> Questions { get; set; }
    //}
}