using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudos.WF.Solid.UI.Controls
{
    public partial class LutadorUserControl : UserControl
    {
        public string NomeDoLutador
        {
            get { return ckbxNomeDoLutador.Text; }
            set { ckbxNomeDoLutador.Text = value; }
        }

        public int Idade
        {
            get { return Convert.ToInt32(lblIdade.Text); }
            set { lblIdade.Text = value.ToString(); }
        }

        public int Lutas
        {
            get { return Convert.ToInt32(lblLutas.Text); }
            set { lblLutas.Text = value.ToString(); }
        }

        public int Derrotas
        {
            get { return Convert.ToInt32(lblDerrotas.Text); }
            set { lblDerrotas.Text = value.ToString(); }
        }

        public int Vitorias
        {
            get { return Convert.ToInt32(lblVitorias.Text); }
            set { lblVitorias.Text = value.ToString(); }
        }

        public int QuantidadeDeArtesMarciais
        {
            get { return Convert.ToInt32(lblQuantidadeDeArtesMarciais.Text); }
            set { lblQuantidadeDeArtesMarciais.Text = value.ToString(); }
        }

        public LutadorUserControl()
        {
            InitializeComponent();
        }
    }
}
