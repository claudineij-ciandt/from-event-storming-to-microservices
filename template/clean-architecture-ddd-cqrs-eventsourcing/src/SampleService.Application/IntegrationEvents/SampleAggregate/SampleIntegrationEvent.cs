using System;
using SampleService.Domain.Seedwork;

namespace SampleService.Application.IntegrationEvents.SampleAggregate
{
    public class SampleIntegrationEvent : DomainEvent
    {
        public string SampleProperty { get; private set; }

        protected SampleIntegrationEvent(Guid aggregateRootId, int version, DateTime createdDate, Header header)
            : base(aggregateRootId, version, createdDate, header)
        {
        }
    }
}