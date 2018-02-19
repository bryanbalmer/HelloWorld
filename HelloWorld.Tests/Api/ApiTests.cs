using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace HelloWorld.Tests.Api
{
    public class ApiTests : BaseHttpClientTests
    {
        [Fact]
        public async void HeartbeatCheck()
        {
            var response = await _httpClient.GetAsync("heartbeat/");
            response.Should().NotBeNull();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
