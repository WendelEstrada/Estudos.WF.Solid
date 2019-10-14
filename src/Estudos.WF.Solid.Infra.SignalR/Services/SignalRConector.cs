using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Timers;

namespace Estudos.WF.Solid.Infra.SignalR.Services
{
    public class SignalRConector : ISignalRConector
    {
        protected HubConnection _hubConnection;
        protected IHubProxy _hubProxy;

        private string _url;
        private string _proxyName;

        private string _method;
        private object[] _args;

        private Timer _timer = new Timer();

        public Action<object> On { get; set; }

        private void ConnectionStateChanged(StateChange connectionState)
        {
            if (connectionState.NewState == ConnectionState.Disconnected || connectionState.NewState == ConnectionState.Reconnecting)
            {
                if (_timer.Enabled == false)
                {
                    _timer.Interval = 10000;
                    _timer.Start();
                    _timer.Elapsed += Timer_Elapsed;
                }
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_hubConnection.State == ConnectionState.Connected)
            {
                Subscribe<string>(_method, _args);

                _timer.Stop();
                return;
            }

            Connect(_url, _proxyName);
        }

        public void Connect(string url, string proxyName)
        {
            _url = url;
            _proxyName = proxyName;

            _hubConnection = new HubConnection(url);
            _hubProxy = _hubConnection.CreateHubProxy(proxyName);

            _hubConnection.Start().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine(task.Exception.Message);
            }).Wait();

            _hubConnection.StateChanged += ConnectionStateChanged;
        }

        public void Subscribe<T>(string method, params object[] args)
        {
            _method = method;
            _args = args;

            _hubProxy.Invoke<T>(method, args).ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine($"There was an error calling send: {task.Exception.GetBaseException()}");
            });
        }

        public void Disconnect()
        {
            _hubConnection.Dispose();
        }
    }
}
