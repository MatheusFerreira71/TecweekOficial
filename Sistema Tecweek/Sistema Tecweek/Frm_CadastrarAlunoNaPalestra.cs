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
                "Pal.Data_Hora, Pal.Max_Alunos, C.Cod_Palestra, C.Cod_Aluno As Cod_Participante from ((TBCadastro_Palestra As C inner " +
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
            SqlCommand cmd = new SqlCommand("Select CPF, Nome, Codigo from TBParticipante;",
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

        public bool HaVagas(int Palestra)
        {
            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão);
            //Pegando as vagas atuais.
            SqlCommand cmd = new SqlCommand()
            {
                Connection = cx.ObjetoConexao,
                CommandText = "select count(*) from TBCadastro_Palestra where Cod_Palestra = " + Palestra.ToString() + ";"
            };
            cx.Conectar();
            SqlDataReader readerAtuais = cmd.ExecuteReader();
            readerAtuais.Read();
            int vagasOcupadas = Convert.ToInt32(readerAtuais.GetValue(0));
            cx.Desconectar();

            //Pegando o número máximo de vagas na palestra. 
            cmd.CommandText = "Select Max_Alunos from TBPalestra where Codigo = " + Palestra.ToString() + ";";
            cx.Conectar();
            SqlDataReader readerMax = cmd.ExecuteReader();
            readerMax.Read();
            int MaxVagas = Convert.ToInt32(readerMax.GetValue(0));
            cx.Desconectar();

            //Verificando se há vagas.
            if (vagasOcupadas == MaxVagas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Frm_CadastrarAlunoNaPalestra_Load(object sender, EventArgs e)
        {
            //Seta o estado dos botões para desligados.
            this.AlterarBotao(false);

            // Popula a tabela de Cadastrados na Palestra
            this.AtualizaTabelaPrincipal();

            // Popula a tabela de alunos
            this.AtualizaTabelaSecundaria();

            DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão);
            BLLPalestra BLLPale = new BLLPalestra(cx);
            CB_CPalestraPalestras.DataSource = BLLPale.Localizar("");
            CB_CPalestraPalestras.ValueMember = "Codigo";
            CB_CPalestraPalestras.DisplayMember = "Nome";
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

        private void GV_CPalestraAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = GV_CPalestraAlunos.CurrentRow.Index;
            Txt_CPalestraCodAluno.Text = Convert.ToString(GV_CPalestraAlunos.Rows[linha].Cells[2].Value.ToString());
            Txt_CPalestraCPFAluno.Text = Convert.ToString(GV_CPalestraAlunos.Rows[linha].Cells[0].Value.ToString());
            Txt_CPalestraNomeAluno.Text = Convert.ToString(GV_CPalestraAlunos.Rows[linha].Cells[1].Value.ToString());
        }

        private void GV_CPalestraPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.operacao == "alterar")
                {
                    int linha = GV_CPalestraPrincipal.CurrentRow.Index;
                    Txt_CPalestraCodAluno.Text = Convert.ToString(GV_CPalestraPrincipal.Rows[linha].Cells[7].Value.ToString());
                    Txt_CPalestraCPFAluno.Text = Convert.ToString(GV_CPalestraPrincipal.Rows[linha].Cells[2].Value.ToString());
                    Txt_CPalestraNomeAluno.Text = Convert.ToString(GV_CPalestraPrincipal.Rows[linha].Cells[1].Value.ToString());
                    if (GV_CPalestraPrincipal.Rows[linha].Cells[6].Value.ToString() == "")
                    {
                        CB_CPalestraPalestras.SelectedValue = 1;
                    }
                    else
                    {
                        CB_CPalestraPalestras.SelectedValue = GV_CPalestraPrincipal.Rows[linha].Cells[6].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_CPalestraExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = GV_CPalestraPrincipal.CurrentRow.Index;
                int cod = Convert.ToInt32(GV_CPalestraPrincipal.Rows[linha].Cells[0].Value.ToString());
                DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o registro de código " + cod + "?",
                    "ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    // Se o usuário marcar Sim, executa a exclusão
                    DALConexoes cx = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                    BLLCadastrarNaPalestra BLLCPales = new BLLCadastrarNaPalestra(cx);
                    BLLCPales.Excluir(cod);
                    MessageBox.Show("Excluído com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Atualiza a tabela!
                    this.AtualizaTabelaPrincipal();
                }
                // Se marcar não, nada acontece e a tela é retornada.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_CPalestraGravar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexoes CX = new DALConexoes(DadosDaConexão.StringDeConexão); //Objetos para gravar os dados;
                BLLCadastrarNaPalestra BLLCPales = new BLLCadastrarNaPalestra(CX);

                if (this.HaVagas(Convert.ToInt32(CB_CPalestraPalestras.SelectedValue))) //Verifica se há vagas.
                {
                    ModeloCadastrarNaPalestra modelo = new ModeloCadastrarNaPalestra
                    {
                        CPalestraCodAluno = Convert.ToInt32(Txt_CPalestraCodAluno.Text),
                        CPalestraCodPalestra = Convert.ToInt32(CB_CPalestraPalestras.SelectedValue)
                    };

                    if (this.operacao == "inserir") // Cadastra no banco o cadastro na palestra.
                    {
                        BLLCPales.Incluir(modelo);
                        MessageBox.Show("Gravado com Sucesso! Código: " + modelo.CPalestraCod.ToString(), "Informativo",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Atualiza a tabela no gridview.
                        this.AtualizaTabelaPrincipal();
                    }
                    else // Altera no banco a O cadastro na Palestra
                    {
                        int linha = GV_CPalestraPrincipal.CurrentRow.Index;
                        int cod = Convert.ToInt32(GV_CPalestraPrincipal.Rows[linha].Cells[0].Value.ToString());
                        modelo.CPalestraCod = cod;
                        BLLCPales.Alterar(modelo);
                        MessageBox.Show("Editado com Sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Atualiza a tabela no gridview.
                        this.AtualizaTabelaPrincipal();
                    }
                    this.LimpaTela();
                    this.AlterarBotao(false);
                    this.operacao = "";
                }
                else // Se o CPF não for válido!
                {
                    MessageBox.Show("Não há vagas!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
