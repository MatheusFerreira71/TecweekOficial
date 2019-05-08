using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecweek_Modelo;
using TecweekDAL;
using TecweekDLL;
using System.Data.SqlClient;

namespace Sistema_Tecweek
{
    public partial class frm_Escolaridade : Form
    {
        public String operacao;

        public void AlterarBotao(bool op) {
            if (op)
            {
                Btn_escolaSalvar.Enabled = true;
                Btn_escolaCancelar.Enabled = true;
                Btn_escolaNovo.Enabled = false;
                Btn_escolaEditar.Enabled = false;
                Btn_escolaExcluir.Enabled = false;
                Txt_escolaNome.Enabled = true;
                Txt_escolaPesquisar.Enabled = false;
            } else
            {
                Btn_escolaNovo.Enabled = true;
                Btn_escolaEditar.Enabled = true;
                Btn_escolaExcluir.Enabled = true;
                Btn_escolaSalvar.Enabled = false;
                Btn_escolaCancelar.Enabled = false;
                Txt_escolaNome.Enabled = false;
                Txt_escolaPesquisar.Enabled = true;
            }
        }

        public void limpaTela()
        {
            Txt_escolaNome.Clear();
        }

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

        private void Btn_escolaNovo_Click(object sender, EventArgs e)
        { 
            this.operacao = "inserir";
            this.AlterarBotao(true);
        }

        private void Btn_escolaCancelar_Click(object sender, EventArgs e)
        {
            this.limpaTela();
            this.AlterarBotao(false);
        }

        private void frm_Escolaridade_Load(object sender, EventArgs e)
        {
            Btn_escolaNovo.Enabled = true;
            Btn_escolaEditar.Enabled = true;
            Btn_escolaExcluir.Enabled = true;
            Btn_escolaSalvar.Enabled = false;
            Btn_escolaCancelar.Enabled = false;
            Txt_escolaNome.Enabled = false;
            Txt_escolaPesquisar.Enabled = true;
            // mostra a tabela no grid view ao iniciar o formulário.
            DALConexoes conexao = new DALConexoes(DadosDaConexão.StringDeConexão);
            SqlCommand cmd = new SqlCommand("Select * from TBEscolaridade", conexao.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        private void Btn_escolaSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloEscolaridade modelo = new modeloEscolaridade
                {
                    escNome = Txt_escolaNome.Text
                };
                DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                BLLEscolaridade blE = new BLLEscolaridade(cx);

                if (this.operacao == "inserir") // Cadastra no banco a escolaridade.
                {
                    blE.Incluir(modelo);
                    MessageBox.Show("Gravado com Sucesso! Código: " + modelo.escCod.ToString(), "Informativo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    SqlCommand cmd = new SqlCommand("Select * from TBEscolaridade", cx.ObjetoConexao);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridView1.DataSource = tabela;
                }
                else // Altera no banco a escolaridade
                {
                    int linha = dataGridView1.CurrentRow.Index;
                    int cod = Convert.ToInt32(dataGridView1.Rows[linha].Cells[0].Value.ToString());
                    modelo.escCod = cod;
                    blE.Alterar(modelo);
                    MessageBox.Show("Editado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    SqlCommand cmd = new SqlCommand("Select * from TBEscolaridade", cx.ObjetoConexao);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridView1.DataSource = tabela;
                }

                this.limpaTela();
                this.AlterarBotao(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Informativo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Btn_escolaExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;
                int cod = Convert.ToInt32(dataGridView1.Rows[linha].Cells[0].Value.ToString());
                DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o registro de código " + cod + "?", 
                    "ATENÇÃO !", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                { 
                    // Se o usuário marcar Sim, executa a exclusão
                    DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                    BLLEscolaridade blE = new BLLEscolaridade(cx);
                    blE.Excluir(cod);
                    MessageBox.Show("Excluído com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Atualiza a tabela!
                    SqlCommand cmd = new SqlCommand("Select * from TBEscolaridade", cx.ObjetoConexao);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridView1.DataSource = tabela;
                } 
                // Se marcar não, nada acontece e a tela é retornada.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_escolaEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotao(true);
            Txt_escolaNome.Focus();
        }

        private void Txt_escolaPesquisar_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLEscolaridade blE = new BLLEscolaridade(cx);
            String valor = Txt_escolaPesquisar.Text;
            if (valor == "Digite para pesquisar...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                SqlCommand cmd = new SqlCommand("Select * from TBEscolaridade", cx.ObjetoConexao);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.
                dataGridView1.DataSource = blE.Localizar(valor);
            }
        }
    }
}