using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.SignalR.Services
{
    public class LutadorSignalRService : SignalRConector, ILutadorSignalRService
    {
        public void SendMessage(string method, params object[] args)
        {
            _hubProxy.Invoke<string>(method, args).ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine($"There was an error calling send: {task.Exception.GetBaseException()}");
            });
        }

        public void ToListen<T>(string method)
        {
            _hubProxy.On<T>(method, param =>
            {
                On.Invoke(param);
            });
        }
    }
}
