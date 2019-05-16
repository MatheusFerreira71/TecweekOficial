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
    public partial class Frm_CadastrarAlunoNaPalestra : Form
    {
        public Frm_CadastrarAlunoNaPalestra()
        {
            InitializeComponent();
        }

        public String operacao;

        public void AlterarBotao(bool op)
        {
            if (op)
            {
                Btn_CPalestraGravar.Enabled = true;
                Btn_CPalestraCancelar.Enabled = true;
                Btn_CPalestraNovo.Enabled = false;
                Btn_CPalestraEditar.Enabled = false;
                Btn_CPalestraExcluir.Enabled = false;
                Txt_CPalestraPesquisarPrincipal.Enabled = false;
                Txt_CPalestraNomeAluno.Enabled = true;
                Txt_CPalestraCPFAluno.Enabled = true;
                Txt_CPalestraCodAluno.Enabled = true;
                Txt_CPalestraPesquisarAlunos.Enabled = true;
                GV_CPalestraAlunos.Enabled = true;
                CB_CPalestraPalestras.Enabled = true;
            }
            else
            {
                Btn_CPalestraGravar.Enabled = false;
                Btn_CPalestraCancelar.Enabled = false;
                Btn_CPalestraNovo.Enabled = true;
                Btn_CPalestraEditar.Enabled = true;
                Btn_CPalestraExcluir.Enabled = true;
                Txt_CPalestraPesquisarPrincipal.Enabled = true;
                Txt_CPalestraNomeAluno.Enabled = false;
                Txt_CPalestraCPFAluno.Enabled = false;
                Txt_CPalestraCodAluno.Enabled = false;
                Txt_CPalestraPesquisarAlunos.Enabled = false;
                GV_CPalestraAlunos.Enabled = false;
                CB_CPalestraPalestras.Enabled = false;
            }
        }

        public void LimpaTela()
        {
            Txt_CPalestraNomeAluno.Clear();
            Txt_CPalestraCPFAluno.Clear();
            Txt_CPalestraCodAluno.Clear();
        }

        private void Frm_CadastrarAlunoNaPalestra_Load(object sender, EventArgs e)
        {
            this.AlterarBotao(false);
            // Atualiza a tabela.
        }

        private void Txt_CPalestraPesquisarAlunos_Enter(object sender, EventArgs e)
        {
            if (Txt_CPalestraPesquisarAlunos.Text == "Pesquisar aluno...")
            {
                Txt_CPalestraPesquisarAlunos.Text = "";
                Txt_CPalestraPesquisarAlunos.ForeColor = Color.Black;
            }
        }

        private void Txt_CPalestraPesquisarAlunos_Leave(object sender, EventArgs e)
        {
            if (Txt_CPalestraPesquisarAlunos.Text == "")
            {
                Txt_CPalestraPesquisarAlunos.Text = "Pesquisar aluno...";
                Txt_CPalestraPesquisarAlunos.ForeColor = Color.Silver;
            }
        }

        private void Txt_CPalestraPesquisarPrincipal_Enter(object sender, EventArgs e)
        {
            if (Txt_CPalestraPesquisarPrincipal.Text == "Digite para pesquisar...")
            {
                Txt_CPalestraPesquisarPrincipal.Text = "";
                Txt_CPalestraPesquisarPrincipal.ForeColor = Color.Black;
            }
        }

        private void Txt_CPalestraPesquisarPrincipal_Leave(object sender, EventArgs e)
        {
            if (Txt_CPalestraPesquisarPrincipal.Text == "")
            {
                Txt_CPalestraPesquisarPrincipal.Text = "Digite para pesquisar...";
                Txt_CPalestraPesquisarPrincipal.ForeColor = Color.Silver;
            }
        }

        private void Btn_CPalestraNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotao(true);
        }

        private void Btn_CPalestraEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotao(true);
        }

        private void Btn_CPalestraCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlterarBotao(false);
            this.operacao = "";
        }
    }
}
