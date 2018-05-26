using Microsoft.Extensions.Configuration;
using System;

namespace AngularClient.Models.Steps
{
    public abstract class Step : UpdatableEntity, IStep
    {        
        public abstract string Action { get; }
        public abstract string Controller { get; }
        public abstract string Name { get; }
        public abstract string Icon { get; }
        public abstract int Order { get;}

        public virtual bool IsLastStep
        {
            get
            {                
                return false;
            }
        }
        
        public bool IsFinished { get; set; }        

        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }
    }
}