using System;

namespace SampleService.Domain.Seedwork
{
    public abstract class Entity : IEntity
    {
        int? _requestedHashCode;

        public Guid Id { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public bool IsTransient()
        {
            return this.Id == default(Guid);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;

            return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }

            return base.GetHashCode();
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null));

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

    }
}