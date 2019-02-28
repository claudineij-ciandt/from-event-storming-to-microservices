using System.Collections.Generic;
using Clean.Architecture.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService service;

        public ExampleController(IExampleService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(service.Get());
        }
    }
}