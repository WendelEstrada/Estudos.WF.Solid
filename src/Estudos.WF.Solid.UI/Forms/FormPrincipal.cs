using Estudos.WF.Solid.Core.Interfaces.CoreServices;
using Estudos.WF.Solid.UI.Controls;
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

        public FormPrincipal(ILutadorService lutadorService)
        {
            _lutadorService = lutadorService;

            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
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
    }
}
