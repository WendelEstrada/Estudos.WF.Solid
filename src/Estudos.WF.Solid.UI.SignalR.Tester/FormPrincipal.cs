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
        private readonly ILutadorSignalRService _lutadorSignalRService;

        public FormPrincipal(ILutadorSignalRService lutadorSignalRService)
        {
            _lutadorSignalRService = lutadorSignalRService;

            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            _lutadorSignalRService.Connect(ConfigurationManager.AppSettings["UrlSignalR"], "CompetidorHub");
            _lutadorSignalRService.Subscribe<string>("JoinTournament", "Adonis Creed");
            _lutadorSignalRService.ToListen<Lutador>("LutadorAdicionado");
            _lutadorSignalRService.On = response =>
            {
                var lutador = response as Lutador;

                Console.WriteLine(lutador.Nome);
            };
        }

        private void BtnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var lutador = new Lutador(1, "Novo lutador", 31, new List<string> { "Boxe" }, 0, 0, 0);

            _lutadorSignalRService.SendMessage("CadastrarLutadorNoTorneio", lutador);
        }
    }
}
