using Stateful.Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebAPI.Interfaces
{
    interface IProvisionUtility
    {
        Task<bool> CheckIfBackendExists(string backendName);
        Task ProvisionNewBackend(string backendName);
        IStatefulBackend GetBackendReference(string backendName);
    }
}
