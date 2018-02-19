using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core
{
    public interface IHelloWorldService
    {
        string GetMessage();
        void SaveMessage(string message);
    }

    public interface IHelloWorldServiceAsync
    {
        Task<string> GetMessage();
        Task SaveMessage(string message);
    }
}
