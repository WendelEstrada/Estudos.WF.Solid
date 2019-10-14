using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Interfaces.SignalRServices
{
    public interface ILutadorSignalRService : ISignalRConector
    {
        void ToListen<T>(string method);
        void SendMessage(string method, params object[] args);
    }
}
