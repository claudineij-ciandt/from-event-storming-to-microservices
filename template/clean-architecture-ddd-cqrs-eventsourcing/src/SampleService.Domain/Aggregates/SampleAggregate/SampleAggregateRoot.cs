using SampleService.Domain.Aggregates.SampleAggregate.DomainEvents;
using SampleService.Domain.Seedwork;

namespace SampleService.Domain.Aggregates.SampleAggregate
{
    public class SampleAggregateRoot : AggregateRoot
    {
        public string SampleProperty1 { get; private set; }

        public SampleValueObject SampleProperty2 { get; private set; }

        public SampleAggregateRoot()
        {
        }

        private SampleAggregateRoot(string sampleProperty1, SampleValueObject sampleProperty2)
        {
            this.SampleProperty1 = sampleProperty1;
            this.SampleProperty2 = sampleProperty2;
        }

        public static SampleAggregateRoot Create(string sampleProperty1, SampleValueObject sampleProperty2)
        {
            return new SampleAggregateRoot(sampleProperty1, sampleProperty2);
        }

        protected override void RegisterDomainEventHandlers()
        {
            Register<SampleDomainEvent>(When);

            // Register other events
        }

        protected void When(SampleDomainEvent domainEvent)
        {
            throw new System.NotImplementedException();
        }

        // Other handlers
    }
}