using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using Microsoft.AspNet.SignalR.Client;
using Polly;
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

        public Action<object> On { get; set; }

        public void Connect(string url, string proxyName)
        {
            _hubConnection = new HubConnection(url);
            _hubProxy = _hubConnection.CreateHubProxy(proxyName);

            _hubConnection.Start().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine(task.Exception.Message);
            }).Wait();

            _hubConnection.StateChanged += _hubConnection_StateChanged;
        }

        private void _hubConnection_StateChanged(StateChange obj)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string method, params object[] args)
        {
            _hubProxy.Invoke<string>(method, args).ContinueWith(task => {
                if (task.IsFaulted)
                    Console.WriteLine($"There was an error calling send: {task.Exception.GetBaseException()}");
                else
                    Console.WriteLine(task.Result);
            });
        }

        public void Subscribe<T>(string method, params object[] args)
        {
            _hubProxy.Invoke<T>(method, args).ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine($"There was an error calling send: {task.Exception.GetBaseException()}");
                else
                    Console.WriteLine(task.Result);
            });

            _hubProxy.On<Lutador>("LutadorAdicionado", param =>
            {
                On.Invoke(param);
            });
        }

        public void Unsubscribe<T>(string method, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
