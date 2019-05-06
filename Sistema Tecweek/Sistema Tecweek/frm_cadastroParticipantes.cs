using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tecweek
{
    public partial class frm_cadastroParticipantes : Form
    {
        public frm_cadastroParticipantes()
        {
            InitializeComponent();
        }

        private void Txt_partiPesquisar_Enter(object sender, EventArgs e)
        {
            if (Txt_partiPesquisar.Text == "Digite para pesquisar...")
            {
                Txt_partiPesquisar.Text = "";
                Txt_partiPesquisar.ForeColor = Color.Black;
            }
        }

        private void Txt_partiPesquisar_Leave(object sender, EventArgs e)
        {
            if (Txt_partiPesquisar.Text == "")
            {
                Txt_partiPesquisar.Text = "Digite para pesquisar...";
                Txt_partiPesquisar.ForeColor = Color.Silver;
            }
        }
    }
}
