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
using Tecweek_Modelo;
namespace Sistema_Tecweek
{
    public partial class frm_CadastroPalestra : Form
    {
        public frm_CadastroPalestra()
        {
            InitializeComponent();
        }

        public String operacao;
        public void AlterarBotao(bool op)
        {
            if (op)
            {
                Btn_PalestraGravar.Enabled = true;
                Btn_PalestraCancelar.Enabled = true;
                Btn_PalestraNovo.Enabled = false;
                Btn_PalestraEditar.Enabled = false;
                Btn_PalestraExcluir.Enabled = false;
                Txt_PalestraNome.Enabled = true;
                Dt_PalestraDataHora.Enabled = true;
                Txt_PalestraMaxAlunos.Enabled = true;
                Txt_PalestraPesquisar.Enabled = false;
            }
            else
            {
                Btn_PalestraNovo.Enabled = true;
                Btn_PalestraEditar.Enabled = true;
                Btn_PalestraExcluir.Enabled = true;
                Btn_PalestraGravar.Enabled = false;
                Btn_PalestraCancelar.Enabled = false;
                Txt_PalestraNome.Enabled = false;
                Dt_PalestraDataHora.Enabled = false;
                Txt_PalestraMaxAlunos.Enabled = false;
                Txt_PalestraPesquisar.Enabled = true;
            }
        }
        public void LimpaTela()
        {
            Txt_PalestraNome.Clear();
            Dt_PalestraDataHora.Value = DateTime.Now;
            Txt_PalestraMaxAlunos.Clear();
        }
        public void AtualizaTabela()
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            SqlCommand cmd = new SqlCommand("Select * from TBPalestra", cx.ObjetoConexao);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        private void Txt_PalestraPesquisar_Enter(object sender, EventArgs e)
        {
            if (Txt_PalestraPesquisar.Text == "Digite para pesquisar...")
            {
                Txt_PalestraPesquisar.Text = "";
                Txt_PalestraPesquisar.ForeColor = Color.Black;
            }
        }

        private void Txt_PalestraPesquisar_Leave(object sender, EventArgs e)
        {
            if (Txt_PalestraPesquisar.Text == "")
            {
                Txt_PalestraPesquisar.Text = "Digite para pesquisar...";
                Txt_PalestraPesquisar.ForeColor = Color.Silver;
            }
        }

        private void frm_CadastroPalestra_Load(object sender, EventArgs e)
        {
            Dt_PalestraDataHora.Value = DateTime.Now;
            this.AlterarBotao(false);
            // mostra a tabela no grid view ao iniciar o formulário.
            this.AtualizaTabela();
        }

        private void Txt_PalestraPesquisar_TextChanged(object sender, EventArgs e)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
            BLLPalestra BLLPale = new BLLPalestra(cx);
            String valor = Txt_PalestraPesquisar.Text;
            if (valor == "Digite para pesquisar...")
            {
                // Se o valor do texto for igual ao placeholder ele irá popular a tabela completa.
                this.AtualizaTabela();
            }
            else
            {
                // Se o valor for diferente do placeholder ele irá executar o método de pesquisa.
                dataGridView1.DataSource = BLLPale.Localizar(valor);
            }
        }

        private void Btn_PalestraNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotao(true);
        }

        private void Btn_PalestraEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotao(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(operacao == "alterar")
            {
                try
                {
                    int linha = dataGridView1.CurrentRow.Index;
                    Txt_PalestraNome.Text = dataGridView1.Rows[linha].Cells[1].Value.ToString();
                    if (dataGridView1.Rows[linha].Cells[2].Value.ToString() == "")
                    {
                        Dt_PalestraDataHora.Value = DateTime.Now;
                    }
                    else
                    {
                        Dt_PalestraDataHora.Value = Convert.ToDateTime(dataGridView1.Rows[linha].Cells[2].Value.ToString());

                    }
                    Txt_PalestraMaxAlunos.Text = dataGridView1.Rows[linha].Cells[3].Value.ToString();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_PalestraCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlterarBotao(false);
            this.operacao = "";
        }

        private void Btn_PalestraExcluir_Click(object sender, EventArgs e)
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
                    BLLPalestra BLLPale = new BLLPalestra(cx);
                    BLLPale.Excluir(cod);
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

        private void Btn_PalestraGravar_Click(object sender, EventArgs e)
        {
            try
            {
                 ModeloPalestra modelo = new ModeloPalestra
                {
                    PalestraNome = Txt_PalestraNome.Text,
                    PalestraDataHora = Dt_PalestraDataHora.Value,
                    PalestraMaxAlunos = Convert.ToInt32(Txt_PalestraMaxAlunos.Text)
                };
                DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                BLLPalestra BLLPale = new BLLPalestra(cx);

                if (this.operacao == "inserir") // Cadastra no banco a escolaridade.
                {
                    BLLPale.Incluir(modelo);
                    MessageBox.Show("Gravado com Sucesso! Código: " + modelo.PalestraCod.ToString(), "Informativo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    this.AtualizaTabela();
                }
                else // Altera no banco a escolaridade
                {
                    int linha = dataGridView1.CurrentRow.Index;
                    int cod = Convert.ToInt32(dataGridView1.Rows[linha].Cells[0].Value.ToString());
                    modelo.PalestraCod = cod;
                    BLLPale.Alterar(modelo);
                    MessageBox.Show("Editado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Atualiza a tabela no gridview.
                    this.AtualizaTabela();
                }

                this.LimpaTela();
                this.AlterarBotao(false);
                this.operacao = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
