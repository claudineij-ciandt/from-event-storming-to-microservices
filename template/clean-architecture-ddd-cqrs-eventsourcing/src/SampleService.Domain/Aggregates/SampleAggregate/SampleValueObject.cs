using System.Collections.Generic;
using SampleService.Domain.Seedwork;

namespace SampleService.Domain.Aggregates.SampleAggregate
{
    public class SampleValueObject : ValueObject
    {
        public SampleValueObject(string sampleProperty1, int sampleProperty2)
        {
            this.SampleProperty1 = sampleProperty1;
            this.SampleProperty2 = sampleProperty2;
        }

        public string SampleProperty1 { get; private set; }

        public int SampleProperty2 { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return SampleProperty1;
            yield return SampleProperty2;
        }
    }
}