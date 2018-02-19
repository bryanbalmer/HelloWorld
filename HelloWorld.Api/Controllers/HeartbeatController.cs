using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers
{
    [Route("api/[controller]")]
    public class HeartbeatController : Controller
    {
        [Route("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
