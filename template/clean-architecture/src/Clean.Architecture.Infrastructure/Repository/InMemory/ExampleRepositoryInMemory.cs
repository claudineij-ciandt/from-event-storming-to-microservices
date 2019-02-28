using System.Collections.Generic;
using Clean.Architecture.Core.Repository;

namespace Clean.Architecture.Infrastructure.Repository.InMemory
{
    public sealed class ExampleRepositoryInMemory : IExampleRepository
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "Example 1", "Example 2" };
        }
    }
}