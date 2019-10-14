using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private readonly ISignalRConector _signalRConector;

        public FormPrincipal(ISignalRConector signalRConector)
        {
            _signalRConector = signalRConector;

            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            _signalRConector.Connect(ConfigurationManager.AppSettings["UrlSignalR"], "CompetidorHub");
            _signalRConector.Subscribe<string>("JoinTournament", "Adonis Creed");
            _signalRConector.On = response =>
            {
                var lutador = response as Lutador;

                Console.WriteLine(lutador.Nome);
            };
        }

        private void BtnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var lutador = new Lutador(1, "Novo lutador", 31, new List<string> { "Boxe" }, 0, 0, 0);

            _signalRConector.SendMessage("CadastrarLutadorNoTorneio", lutador);
        }
    }
}
