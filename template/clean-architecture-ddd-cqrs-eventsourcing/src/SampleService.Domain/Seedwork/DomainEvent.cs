using System;

namespace SampleService.Domain.Seedwork
{
    public class DomainEvent : IDomainEvent
    {
        public Guid AggregateRootId { get; private set; }
        public int Version { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Header Header { get; private set; }

        protected DomainEvent(Guid aggregateRootId, int version, DateTime createdDate, Header header)
        {
            this.AggregateRootId = aggregateRootId;
            this.Version = version;
            this.CreatedDate = createdDate;
            this.Header = header;
        }

        public void SetHeader(Header header)
        {
            this.Header = header;
        }
    }
}