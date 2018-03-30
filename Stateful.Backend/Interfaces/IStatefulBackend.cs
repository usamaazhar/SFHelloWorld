using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stateful.Backend.Interfaces
{
    public interface IStatefulBackend : IService
    {
        // with service remoting its mandatory to return a task
        Task<string> PingBackend();
    }
}
