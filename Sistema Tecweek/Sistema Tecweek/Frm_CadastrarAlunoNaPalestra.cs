using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecweekDAL;
using TecweekDLL;

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

        public void AtualizaTabelaPrincipal()
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            SqlCommand cmd = new SqlCommand("Select C.Codigo, Par.Nome, Par.CPF, Pal.Nome As Palestra, " +
                "Pal.Data_Hora, Pal.Max_Alunos, C.Cod_Palestra from ((TBCadastro_Palestra As C inner " +
                "join TBPalestra As Pal on C.Cod_Palestra = Pal.Codigo) inner join TBParticipante As " +
                "Par ON C.Cod_Aluno = Par.Codigo);",
                cx.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GV_CPalestraPrincipal.DataSource = tabela;
        }

        public void AtualizaTabelaSecundaria()
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            SqlCommand cmd = new SqlCommand("Select Codigo, Nome, CPF from TBParticipante;",
                cx.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            GV_CPalestraAlunos.DataSource = tabela;
        }

        public DataTable LocalizarAluno(String Valor)
        {
            DALConexoes conexao = new DALConexoes(DadosDaConexão.StringDeConexão);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Codigo, Nome, CPF from TBParticipante where " +
                "Nome like '%" + Valor + "%' OR CPF like '%" + Valor + "%'",
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        private void Frm_CadastrarAlunoNaPalestra_Load(object sender, EventArgs e)
        {
            //Seta o estado dos botões para desligados.
            this.AlterarBotao(false);

            // Popula a tabela de Cadastrados na Palestra
            this.AtualizaTabelaPrincipal();

            // Popula a tabela de alunos
            this.AtualizaTabelaSecundaria();
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

        private void Txt_CPalestraPesquisarAlunos_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLParticipante BLLParti = new BLLParticipante(cx);
            String valor = Txt_CPalestraPesquisarAlunos.Text;
            if (valor == "Pesquisar aluno...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                this.AtualizaTabelaSecundaria();
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.

                GV_CPalestraAlunos.DataSource = LocalizarAluno(valor);
            }
        }

        private void Txt_CPalestraPesquisarPrincipal_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLCadastrarNaPalestra BLLCPales = new BLLCadastrarNaPalestra(cx);
            String valor = Txt_CPalestraPesquisarPrincipal.Text;
            if (valor == "Digite para pesquisar...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                this.AtualizaTabelaPrincipal();
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.
                GV_CPalestraPrincipal.DataSource = BLLCPales.Localizar(valor);
            }
        }
    }
}
