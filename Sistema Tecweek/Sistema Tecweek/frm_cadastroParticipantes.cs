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
            SqlCommand cmd = new SqlCommand("select P.Codigo, P.CPF, P.Nome, " +
                "P.DataNasc As DataNascimento, P.Email, P.Telefone, E.Nome AS Escolaridade, " +
                "P.Cod_Escolaridade From TBParticipante as P inner join TBEscolaridade as E on P.Cod_Escolaridade = E.Codigo", 
                cx.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
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
            else if (verificador[0] && verificador[1])
            {
                return true;
            }
            else
            {
                return false;
            }
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
            Cb_partiEscolaridade.DataSource = BLLEscol.Localizar("%");
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
                    if (dataGridView1.Rows[linha].Cells[7].Value.ToString() == "")
                    {
                        Cb_partiEscolaridade.SelectedValue = 1;
                    }
                    else
                    {
                        Cb_partiEscolaridade.SelectedValue = dataGridView1.Rows[linha].Cells[7].Value.ToString();
                    }
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
                if (Txt_partiCPF.TextLength < 11)
                {
                    MessageBox.Show("CPF precisa de 11 números!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    if (this.CPF_Valido(Txt_partiCPF.Text)) //Verifica se o CPF é válido.
                    {
                        ModeloParticipante modelo = new ModeloParticipante
                        {
                            ParticipanteNome = Txt_partiNome.Text,
                            ParticipanteCPF = Txt_partiCPF.Text,
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
                    else // Se o CPF não for válido!
                    {
                        MessageBox.Show("CPF INVÁLIDO!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}