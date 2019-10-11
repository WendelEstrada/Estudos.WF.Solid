using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.SignalR.Services
{
    public class SignalRConector : ISignalRConector
    {
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        public event EventHandler SignalRResponse;

        public Task Connect(string url, string proxyName)
        {
            _hubConnection = new HubConnection(url);
            _hubProxy = _hubConnection.CreateHubProxy(proxyName);

            var conector = _hubConnection.Start().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine(task.Exception.Message);
            });

            conector.Wait();
            return conector;
        }

        public Task<T> Invoke<T>(string method, params object[] args)
        {
            var teste = _hubProxy.Invoke<T>(method, args).ContinueWith(task => {
                if (task.IsFaulted)
                {
                    Console.WriteLine("There was an error calling send: {0}",
                                      task.Exception.GetBaseException());
                }
                else
                {
                    Console.WriteLine(task.Result);
                }
            });

            return teste as Task<T>;
        }
    }
}
