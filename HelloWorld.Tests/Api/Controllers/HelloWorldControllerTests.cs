using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace HelloWorld.Tests.Api.Controllers
{
    public class HelloWorldControllerTests : BaseHttpClientTests
    {
        [Fact]
        public async void CanGetMessage()
        {
            var response = await _httpClient.GetAsync("helloworld/");
            var message = await response.Content.ReadAsStringAsync();

            response.Should().NotBeNull();
            message.ShouldBeEquivalentTo("Hello World");
        }
    }
}
