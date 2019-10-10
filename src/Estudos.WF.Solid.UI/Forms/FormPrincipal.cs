using Estudos.WF.Solid.Core.Interfaces.CoreServices;
using Estudos.WF.Solid.UI.Controls;
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

namespace Estudos.WF.Solid.UI.Forms
{
    public partial class FormPrincipal : Form
    {
        private readonly ILutadorService _lutadorService;
        private HubConnection _hubConnection;

        public FormPrincipal(ILutadorService lutadorService)
        {
            _lutadorService = lutadorService;

            InitializeComponent();
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            var lutadores = _lutadorService.GetAll();

            foreach (var lutador in lutadores)
            {
                var lutadorUserControl = new LutadorUserControl()
                {
                    NomeDoLutador = lutador.Nome,
                    Idade = lutador.Idade,
                    Derrotas = lutador.Derrotas,
                    Vitorias = lutador.Vitorias,
                    Lutas = lutador.Lutas,
                    QuantidadeDeArtesMarciais = lutador.ArtesMarciais.Count(),
                    Location = new Point()
                };

                flowLayoutPanel.Controls.Add(lutadorUserControl);
            }
        }

        private void BtnConnectSignalR_Click(object sender, EventArgs e)
        {
            _hubConnection = new HubConnection("http://localhost:55235/signalr");
            var hub = _hubConnection.CreateHubProxy("CompetidorHub");

            Task teste = _hubConnection.Start().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    MessageBox.Show(task.Exception.Message);
            });

            teste.Wait();

            hub.Invoke<string>("JoinTournament", "Rocky Balboa").ContinueWith(task => {
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

            hub.On<string>("DisplayMessageAll", param => {
                Console.WriteLine(param);
            });
        }
    }
}
