using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudos.WF.Solid.UI.SignalR.Tester
{
    public partial class FormPrincipal : Form
    {
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        public FormPrincipal()
        {
            InitializeComponent();

            _hubConnection = new HubConnection("http://localhost:55235/signalr");
            _hubProxy = _hubConnection.CreateHubProxy("CompetidorHub");

            _hubConnection.Start().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    MessageBox.Show(task.Exception.Message);
            }).Wait();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            _hubProxy.Invoke<string>("JoinTournament", "Adonis Creed").ContinueWith(task => {
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
        }

        private void BtnEnviarMensagem_Click(object sender, EventArgs e)
        {
            _hubProxy.Invoke<string>("DisplayMessageAll", TxtMensagem.Text).ContinueWith(task => {
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
        }
    }
}
