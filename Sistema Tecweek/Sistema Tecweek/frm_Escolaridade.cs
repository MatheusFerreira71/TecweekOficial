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
    public partial class frm_Escolaridade : Form
    {
        public frm_Escolaridade()
        {
            InitializeComponent();
        }

        private void Txt_pesquisar_Enter(object sender, EventArgs e)
        {
            if(Txt_escolaPesquisar.Text == "Digite para pesquisar...")
            {
                Txt_escolaPesquisar.Text = "";
                Txt_escolaPesquisar.ForeColor = Color.Black;
            }
        }

        private void Txt_pesquisar_Leave(object sender, EventArgs e)
        {
            if (Txt_escolaPesquisar.Text == "")
            {
                Txt_escolaPesquisar.Text = "Digite para pesquisar...";
                Txt_escolaPesquisar.ForeColor = Color.Silver;
            }
        }
    }
}
