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
    public partial class frm_cadastroParticipantes : Form
    {
        public frm_cadastroParticipantes()
        {
            InitializeComponent();
        }

        public String operacao;

        public void AlterarBotao(bool op)
        {
            if (op)
            {
                Btn_partiGravar.Enabled = true;
                Btn_partiCancelar.Enabled = true;
                Btn_partiNovo.Enabled = false;
                Btn_partiEditar.Enabled = false;
                Btn_partiExcluir.Enabled = false;
                Txt_partiNome.Enabled = true;
                Txt_partiCPF.Enabled = true;
                Txt_partiEmail.Enabled = true;
                Txt_partiTelefone.Enabled = true;
                dtp_partiNascimento.Enabled = true;
                Cb_partiEscolaridade.Enabled = true;
                Txt_partiPesquisar.Enabled = false;
            }
            else
            {
                Btn_partiNovo.Enabled = true;
                Btn_partiEditar.Enabled = true;
                Btn_partiExcluir.Enabled = true;
                Btn_partiGravar.Enabled = false;
                Btn_partiCancelar.Enabled = false;
                Txt_partiNome.Enabled = false;
                Txt_partiCPF.Enabled = false;
                Txt_partiEmail.Enabled = false;
                Txt_partiTelefone.Enabled = false;
                dtp_partiNascimento.Enabled = false;
                Cb_partiEscolaridade.Enabled = false;
                Txt_partiPesquisar.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            Txt_partiNome.Clear();
            Txt_partiCPF.Clear();
            Txt_partiEmail.Clear();
            Txt_partiTelefone.Clear();
            dtp_partiNascimento.Value = DateTime.Today;
        }

        public void AtualizaTabela()
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            SqlCommand cmd = new SqlCommand("Select * from TBParticipante", cx.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
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

        private void frm_cadastroParticipantes_Load(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão);
            BLLEscolaridade BLLEscol = new BLLEscolaridade(cx);
            dtp_partiNascimento.Value = DateTime.Today;
            Cb_partiEscolaridade.DataSource = BLLEscol.Localizar("");
            Cb_partiEscolaridade.DisplayMember = "Nome";
            Cb_partiEscolaridade.ValueMember = "Codigo";
            this.AlterarBotao(false);
            // mostra a tabela no grid view ao iniciar o formulário.
            this.AtualizaTabela();
        }

        private void Txt_partiPesquisar_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLParticipante BLLParti = new BLLParticipante(cx);
            String valor = Txt_partiPesquisar.Text;
            if (valor == "Digite para pesquisar...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                this.AtualizaTabela();
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.
                dataGridView1.DataSource = BLLParti.Localizar(valor);
            }
        }

        private void Btn_partiNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotao(true);
        }

        private void Btn_partiEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotao(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (operacao == "alterar")
            {
                try
                {
                    int linha = dataGridView1.CurrentRow.Index;
                    Txt_partiCPF.Text = dataGridView1.Rows[linha].Cells[1].Value.ToString();
                    Txt_partiNome.Text = dataGridView1.Rows[linha].Cells[2].Value.ToString();
                    if (dataGridView1.Rows[linha].Cells[3].Value.ToString() == "")
                    {
                        dtp_partiNascimento.Value = DateTime.Today;
                    }
                    else
                    {
                        dtp_partiNascimento.Value = Convert.ToDateTime(dataGridView1.Rows[linha].Cells[3].Value.ToString());

                    }
                    Txt_partiEmail.Text = dataGridView1.Rows[linha].Cells[4].Value.ToString();
                    Txt_partiTelefone.Text = dataGridView1.Rows[linha].Cells[5].Value.ToString();
                    Cb_partiEscolaridade.SelectedValue = dataGridView1.Rows[linha].Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_partiExcluir_Click(object sender, EventArgs e)
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
                    BLLParticipante BLLParti = new BLLParticipante(cx);
                    BLLParti.Excluir(cod);
                    MessageBox.Show("Excluído com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Atualiza a tabela!
                    this.AtualizaTabela();
                }
                // Se marcar não, nada acontece e a tela é retornada.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_partiCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlterarBotao(false);
            this.operacao = "";
        }

        private void Btn_partiGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloParticipante modelo = new ModeloParticipante
                {
                    ParticipanteNome = Txt_partiNome.Text,
                    ParticipanteDataNasc = dtp_partiNascimento.Value,
                    ParticipanteCodEscolaridade = Convert.ToInt32(Cb_partiEscolaridade.SelectedValue),
                    ParticipanteEmail = Txt_partiEmail.Text,
                    ParticipanteTelefone = Txt_partiTelefone.Text
                };
                DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                BLLParticipante BLLParti = new BLLParticipante(cx);

                if (this.operacao == "inserir") // Cadastra no banco a escolaridade.
                {
                    BLLParti.Incluir(modelo);
                    MessageBox.Show("Gravado com Sucesso! Código: " + modelo.ParticipanteCod.ToString(), "Informativo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    this.AtualizaTabela();
                }
                else // Altera no banco a escolaridade
                {
                    int linha = dataGridView1.CurrentRow.Index;
                    int cod = Convert.ToInt32(dataGridView1.Rows[linha].Cells[0].Value.ToString());
                    modelo.ParticipanteCod = cod;
                    BLLParti.Alterar(modelo);
                    MessageBox.Show("Editado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    this.AtualizaTabela();
                }
                this.LimpaTela();
                this.AlterarBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}