using AngularClient.Models.Identity;
using System;

namespace AngularClient.Models
{
    public abstract class UpdatableEntity : Entity
    {
        public UpdatableEntity()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.LastModificationOn = this.CreatedOn;
        }

        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime LastModificationOn { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}