using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Core;
using System.Net;

namespace HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        private IHelloWorldService _helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [Route("")]
        public IActionResult Get()
        {
            var msg = _helloWorldService.GetMessage();
            return Ok(msg);
        }
    }
}
