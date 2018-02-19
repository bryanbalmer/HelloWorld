using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Core
{
    public class HelloWorldService : IHelloWorldService
    {
        private string _msg = "Hello World";

        public string GetMessage()
        {
            return _msg;
        }

        public void SaveMessage(string message)
        {
            _msg = message;
        }
    }
}
