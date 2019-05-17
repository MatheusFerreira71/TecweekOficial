using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecweek_Modelo;

namespace TecweekDAL
{
    public class DALCadastroNaPalestra
    {
        private DALConexoes conexao;
        public DALCadastroNaPalestra(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCadastrarNaPalestra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into TBCadastro_Palestra(Cod_Aluno, Cod_Palestra) " +
                "values (@CodAluno, @CodPalestra); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@CodAluno", modelo.CPalestraCodAluno);
            cmd.Parameters.AddWithValue("@CodPalestra", modelo.CPalestraCodPalestra);
            conexao.Conectar();
            modelo.CPalestraCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloCadastrarNaPalestra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update TBCadastro_Palestra set Cod_Aluno = @CodAluno, Cod_Palestra = @CodPalestra " +
                " where Codigo = @Codigo;"
            };
            cmd.Parameters.AddWithValue("@Codigo", modelo.CPalestraCod);
            cmd.Parameters.AddWithValue("@CodAluno", modelo.CPalestraCodAluno);
            cmd.Parameters.AddWithValue("@CodPalestra", modelo.CPalestraCodPalestra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from TBCadastro_Palestra where Codigo =" + codigo.ToString()

            };
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select C.Codigo, Par.Nome, Par.CPF, Pal.Nome as Palestra, " +
                "Pal.Data_Hora, Pal.Max_Alunos, C.Cod_Palestra from ((TBCadastro_Palestra As C inner " +
                "join TBPalestra As Pal on C.Cod_Palestra = Pal.Codigo) inner join TBParticipante As " +
                "Par ON C.Cod_Aluno = Par.Codigo) where Par.Nome like '%" + valor + "%' OR Par.CPF like '%" + valor + "%' OR Pal.Nome like '%" + valor +
                "%' OR Pal.Data_Hora like '%" + valor + "%' OR Pal.Max_Alunos like '%" + valor + "%'",
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCadastrarNaPalestra CarregaModeloCPalestra(int Codigo)
        {
            ModeloCadastrarNaPalestra modelo = new ModeloCadastrarNaPalestra();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "Select * from TBCadastro_Palestra where Codigo =" + Codigo.ToString()
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CPalestraCod = Convert.ToInt32(registro["Codigo"]);
                modelo.CPalestraCodAluno = Convert.ToInt32(registro["Cod_Aluno"]);
                modelo.CPalestraCodPalestra = Convert.ToInt32(registro["Cod_Palestra"]);
            }
            conexao.Desconectar();
            return modelo;
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
    }
}
