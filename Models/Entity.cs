using System;

namespace AngularClient.Models
{
    public abstract class Entity : IEntity
    {
        public virtual int Id { get; protected set; }

        public virtual bool IsNew()
        {
            return this.Id == 0;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Entity)) return false;
            if (this.IsNew())
            {
                return ReferenceEquals(obj, this);
            }

            var other = (Entity)obj;
            if (!Object.Equals(other.Id, this.Id))
            {
                return false;
            }

            var otherType = other.GetType();
            var thisType = this.GetType();
            return thisType.IsAssignableFrom(otherType) ||
                   otherType.IsAssignableFrom(thisType);
        }
        public static bool operator ==(Entity left, Entity right)
        {
            return Equals(left,right);
        }
        public static bool operator !=(Entity left, Entity right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            if (this.IsNew())
            {
                return base.GetHashCode();
            }

            return this.Id.GetHashCode();
        }
    }
}