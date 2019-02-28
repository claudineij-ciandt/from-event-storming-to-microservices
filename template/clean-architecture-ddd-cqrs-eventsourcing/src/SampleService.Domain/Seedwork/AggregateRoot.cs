using System;
using System.Collections.Generic;

namespace SampleService.Domain.Seedwork
{
    public abstract class AggregateRoot : Entity, IAggregateRoot
    {
        private readonly Dictionary<Type, Action<object>> handlers = new Dictionary<Type, Action<object>>();
        private readonly List<DomainEvent> domainEvents = new List<DomainEvent>();

        public int Version { get; private set; }

        public AggregateRoot()
        {
            RegisterDomainEventHandlers();
            Version = 0;
        }

        public IReadOnlyCollection<DomainEvent> GetEvents()
        {
            return domainEvents;
        }

        public void Apply(DomainEvent domainEvent)
        {
            handlers[domainEvent.GetType()](domainEvent);
            Version++;
        }

        protected void Register<T>(Action<T> when)
        {
            handlers.Add(typeof(T), e => when((T)e));
        }

        protected void Raise(DomainEvent domainEvent)
        {
            domainEvents.Add(domainEvent);
            Apply(domainEvent);
        }

        protected abstract void RegisterDomainEventHandlers();
    }
}