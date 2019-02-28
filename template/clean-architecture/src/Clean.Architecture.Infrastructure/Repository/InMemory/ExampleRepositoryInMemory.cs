using System.Collections.Generic;
using Clean.Architecture.Core.Model;
using Clean.Architecture.Core.Repository;

namespace Clean.Architecture.Infrastructure.Repository.InMemory
{
    public sealed class ExampleRepositoryInMemory : IExampleRepository
    {
        public IEnumerable<Example> Get()
        {
            return new List<Example> 
            {
                new Example { Id = 1 },
                new Example { Id = 2 }
            };
        }
    }
}