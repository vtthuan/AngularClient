using AngularClient.Models.Steps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AngularClient.Models
{
    public class Transaction : UpdatableEntity
    {
        public Transaction()
        {

        }
        public static int NumberSteps;

        public ICollection<Step> Steps { get; private set; }

        public Step CurrentStep
        {
            get
            {
                return Steps.ElementAt(StepIndexAllowMaximum);
            }
        }               
        

        /// <summary>
        /// Maximum index user can go
        /// </summary>
        public int StepIndexAllowMaximum { get; private set; }
        public Video Video { get; set; }
        public int VideoId { get; set; }

        public bool IsFinished { get; set; }
        public string Token { get; set; }

        public void MoveNext()
        {
            CurrentStep.IsFinished = true;
            IsFinished = CurrentStep.IsLastStep;
            StepIndexAllowMaximum++;
        }

        private void Initialize()
        {
            Steps = typeof(IStep)
                .Assembly
                .GetTypes()
                .Where(t => !t.IsAbstract && typeof(IStep).IsAssignableFrom(t))
                .Select(t => (Step)Activator.CreateInstance(t))
                .OrderBy(t=>t.Order)
                .ToList();

            foreach(var step in Steps)
            {
                step.Transaction = this;
            }
        }

        static Transaction()
        {
            
        }

        public Transaction(string userId, Video video)
        {
            Initialize();
            NumberSteps = Steps.Count;
            UserId = userId;
            Video = video;
            if(Steps.Count == 0)
            {
                throw new InvalidOperationException("Cant find the at least a step");
            }
            StepIndexAllowMaximum = 0;
            Token = Guid.NewGuid().ToString();
            IsFinished = false;
        }

        public void Restart()
        {
            this.IsFinished = false;
            this.StepIndexAllowMaximum = 0;
        }
    }
}