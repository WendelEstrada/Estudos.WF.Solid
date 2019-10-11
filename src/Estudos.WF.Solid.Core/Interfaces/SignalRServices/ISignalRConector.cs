using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Interfaces.SignalRServices
{
    public interface ISignalRConector
    {
        Task Connect(string url, string proxyName);
        Task<T> Invoke<T>(string method, params object[] args);
    }
}
