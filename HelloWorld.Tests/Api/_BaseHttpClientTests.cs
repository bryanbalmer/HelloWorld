using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HelloWorld.Tests.Api
{
    public class BaseHttpClientTests : IDisposable
    {
        protected IConfigurationRoot _config;

        private string _baseApiUrl;
        protected HttpClient _httpClient;

        protected BaseHttpClientTests()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            _config = builder.Build();
            _baseApiUrl = _config["baseApiUrl"];

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseApiUrl);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
