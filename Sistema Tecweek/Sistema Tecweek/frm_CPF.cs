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
using Tecweek_Modelo;
using TecweekDAL;
using TecweekDLL;

namespace Sistema_Tecweek
{
    public partial class frm_CPF : Form
    {
        public frm_CPF()
        {
            InitializeComponent();
        }

        public String operacao;

        public void AlterarBotao(bool op)
        {
            if (op)
            {
                Btn_cpfGravar.Enabled = true;
                Btn_cpfCancelar.Enabled = true;
                Btn_cpfNovo.Enabled = false;
                Btn_cpfEditar.Enabled = false;
                Btn_cpfExcluir.Enabled = false;
                Txt_cpfNome.Enabled = true;
                Txt_cpfPesquisar.Enabled = false;
            }
            else
            {
                Btn_cpfNovo.Enabled = true;
                Btn_cpfEditar.Enabled = true;
                Btn_cpfExcluir.Enabled = true;
                Btn_cpfGravar.Enabled = false;
                Btn_cpfCancelar.Enabled = false;
                Txt_cpfNome.Enabled = false;
                Txt_cpfPesquisar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            Txt_cpfNome.Clear();
        }

        public bool CPF_Valido(String cpf)
        {
            bool[] verificador;
            verificador = new bool[2];
            int[] CPF_Vetor;
            CPF_Vetor = new int[11];
            int calculo = 0, aux = 10;
            for (int i = 0; i < 11; i++)
            {
                CPF_Vetor[i] = Convert.ToInt32(cpf[i].ToString());
            }
            for (int i = 0; i <= 8; i++)
            {
                calculo += CPF_Vetor[i] * aux;
                aux -= 1;
            }
            calculo *= 10;
            calculo %= 11;
            if (calculo == 10)
            {
                calculo = 0;
            }
            if (calculo == CPF_Vetor[9])
            {
                verificador[0] = true;
            }
            else
            {
                verificador[0] = false;
            }
            calculo = 0;
            aux = 11;
            for (int i = 0; i <= 9; i++)
            {
                calculo += CPF_Vetor[i] * aux;
                aux -= 1;
            }
            calculo *= 10;
            calculo %= 11;
            if (calculo == 10)
            {
                calculo = 0;
            }
            if (calculo == CPF_Vetor[10])
            {
                verificador[1] = true;
            }
            else
            {
                verificador[0] = false;
            }
            if (
                CPF_Vetor[0] == CPF_Vetor[1]
                && CPF_Vetor[1] == CPF_Vetor[2]
                && CPF_Vetor[2] == CPF_Vetor[3]
                && CPF_Vetor[3] == CPF_Vetor[4]
                && CPF_Vetor[4] == CPF_Vetor[5]
                && CPF_Vetor[5] == CPF_Vetor[6]
                && CPF_Vetor[6] == CPF_Vetor[7]
                && CPF_Vetor[7] == CPF_Vetor[8]
                && CPF_Vetor[8] == CPF_Vetor[9]
                && CPF_Vetor[9] == CPF_Vetor[10]
                )
            {
                return false;
            }
            else if(verificador[0] && verificador[1])
            {
                return true;
            }
            else
            {
                return false;
            }
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

        private void Btn_cpfNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotao(true);
        }

        private void Btn_cpfEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotao(true);
            Txt_cpfNome.Focus();
        }

        private void Btn_cpfExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;
                int cod = Convert.ToInt32(dataGridView1.Rows[linha].Cells[0].Value.ToString());
                DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o registro de código " + cod + "?",
                    "ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    // Se o usuário marcar Sim, executa a exclusão
                    DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                    BLLCpf blC = new BLLCpf(cx);
                    blC.Excluir(cod);
                    MessageBox.Show("Excluído com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Atualiza a tabela!
                    SqlCommand cmd = new SqlCommand("Select * from TB_CPF", cx.ObjetoConexao);
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

        private void Btn_cpfGravar_Click(object sender, EventArgs e)
        {
            try
            {   if (this.CPF_Valido(Txt_cpfNome.Text))
                {
                    ModeloCPF modelo = new ModeloCPF
                    {
                        CpfNome = Txt_cpfNome.Text
                    };
                    DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                    BLLCpf blC = new BLLCpf(cx);
                    if (this.operacao == "inserir") // Cadastra no banco a escolaridade.
                    {
                        blC.Incluir(modelo);
                        MessageBox.Show("Gravado com Sucesso! Código: " + modelo.CpfCod.ToString(), "Informativo",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Atualiza a tabela no gridview.
                        SqlCommand cmd = new SqlCommand("Select * from TB_CPF", cx.ObjetoConexao);
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
                        modelo.CpfCod = cod;
                        blC.Alterar(modelo);
                        MessageBox.Show("Editado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Atualiza a tabela no gridview.
                        SqlCommand cmd = new SqlCommand("Select * from TB_CPF", cx.ObjetoConexao);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        dataGridView1.DataSource = tabela;
                    }
                    this.LimpaTela();
                    this.AlterarBotao(false);
                }
                else
                {
                    MessageBox.Show("CPF inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LimpaTela();
                    this.AlterarBotao(false);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cpfCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlterarBotao(false);
        }

        private void Txt_cpfPesquisar_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLCpf blC = new BLLCpf(cx);
            String valor = Txt_cpfPesquisar.Text;
            if (valor == "Digite para pesquisar...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                SqlCommand cmd = new SqlCommand("Select * from TB_CPF", cx.ObjetoConexao);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.
                dataGridView1.DataSource = blC.Localizar(valor);
            }
        }

        private void frm_CPF_Load(object sender, EventArgs e)
        {
            Btn_cpfNovo.Enabled = true;
            Btn_cpfEditar.Enabled = true;
            Btn_cpfExcluir.Enabled = true;
            Btn_cpfGravar.Enabled = false;
            Btn_cpfCancelar.Enabled = false;
            Txt_cpfNome.Enabled = false;
            Txt_cpfPesquisar.Enabled = true;
            // mostra a tabela no grid view ao iniciar o formulário.
            DALConexoes conexao = new DALConexoes(DadosDaConexão.StringDeConexão);
            SqlCommand cmd = new SqlCommand("Select * from TB_CPF", conexao.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }
    }
}