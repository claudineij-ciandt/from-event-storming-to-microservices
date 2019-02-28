using System.Collections.Generic;

namespace Clean.Architecture.Core.Repository
{
    public interface IExampleRepository
    {
         IEnumerable<string> Get();
    }
}