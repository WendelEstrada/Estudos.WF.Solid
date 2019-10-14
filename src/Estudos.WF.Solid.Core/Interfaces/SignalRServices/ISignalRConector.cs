using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Interfaces.SignalRServices
{
    public interface ISignalRConector
    {
        Action<object> On { get; set; }

        void Connect(string url, string proxyName);
        void Subscribe<T>(string method, params object[] args);
        void Disconnect();
    }
}
