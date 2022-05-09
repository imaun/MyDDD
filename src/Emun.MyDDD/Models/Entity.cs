using System;

namespace Emun.MyDDD.Models
{
    /// <summary>
    /// Base class for Entities 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class Entity<TKey>
    {
        
        public TKey Id { get; protected set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            return hasSameKey(obj as Entity<TKey>);
        }

        private bool hasSameKey(Entity<TKey> other)
        {
            if (other == null) return false;

            return other.Id.Equals(Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}