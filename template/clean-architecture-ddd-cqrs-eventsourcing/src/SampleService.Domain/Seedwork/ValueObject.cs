using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleService.Domain.Seedwork
{
    public abstract class ValueObject : IValueObject
    {
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            ValueObject other = (ValueObject)obj;
            IEnumerator<object> thisValues = GetAtomicValues().GetEnumerator();
            IEnumerator<object> otherValues = other.GetAtomicValues().GetEnumerator();

            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (ReferenceEquals(thisValues.Current, null) ^ ReferenceEquals(otherValues.Current, null))
                {
                    return false;
                }

                if (thisValues.Current != null && !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null));

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !(left == right);
        }

        protected abstract IEnumerable<object> GetAtomicValues();
    }
}