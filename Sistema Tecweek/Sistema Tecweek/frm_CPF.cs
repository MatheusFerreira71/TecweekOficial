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
    public partial class frm_CPF : Form
    {
        public frm_CPF()
        {
            InitializeComponent();
        }

        private void Txt_periodoPesquisar_Enter(object sender, EventArgs e)
        {
            if (Txt_cpfPesquisar.Text == "Digite para pesquisar...")
            {
                Txt_cpfPesquisar.Text = "";
                Txt_cpfPesquisar.ForeColor = Color.Black;
            }
        }

        private void Txt_periodoPesquisar_Leave(object sender, EventArgs e)
        {
            if (Txt_cpfPesquisar.Text == "")
            {
                Txt_cpfPesquisar.Text = "Digite para pesquisar...";
                Txt_cpfPesquisar.ForeColor = Color.Silver;
            }
        }
    }
}
