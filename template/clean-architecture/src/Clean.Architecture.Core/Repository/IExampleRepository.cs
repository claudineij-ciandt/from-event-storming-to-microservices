using System.Collections.Generic;
using Clean.Architecture.Core.Model;

namespace Clean.Architecture.Core.Repository
{
    public interface IExampleRepository
    {
         IEnumerable<Example> Get();
    }
}