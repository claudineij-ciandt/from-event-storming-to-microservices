using System;
using SampleService.Domain.Seedwork;

namespace SampleService.Domain.Aggregates.SampleAggregate.DomainEvents
{
    public class SampleDomainEvent : DomainEvent
    {
        public string SampleProperty { get; private set; }

        protected SampleDomainEvent(Guid aggregateRootId, int version, DateTime createdDate, Header header, string sampleProperty)
            : base(aggregateRootId, version, createdDate, header)
        {
            this.SampleProperty = sampleProperty;
        }

        protected SampleDomainEvent(Guid aggregateRootId, int version, string sampleProperty)
            : base(aggregateRootId, version, DateTime.Now, null)
        {
            this.SampleProperty = sampleProperty;
        }
    }
}