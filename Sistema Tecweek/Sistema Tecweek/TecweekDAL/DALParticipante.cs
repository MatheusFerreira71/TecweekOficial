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
    public class DALParticipante
    {
        private DALConexoes conexao;
        public DALParticipante(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParticipante modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into TBParticipante(CPF, Nome, DataNasc, Email, Telefone, Cod_Escolaridade) " +
                "values (@CPF, @Nome, @DataNasc, @Email, @Telefone, @CodEscolaridade); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@CPF", modelo.ParticipanteCPF);
            cmd.Parameters.AddWithValue("@Nome", modelo.ParticipanteNome);
            cmd.Parameters.AddWithValue("@DataNasc", modelo.ParticipanteDataNasc);
            cmd.Parameters.AddWithValue("@Email", modelo.ParticipanteEmail);
            cmd.Parameters.AddWithValue("@Telefone", modelo.ParticipanteTelefone);
            cmd.Parameters.AddWithValue("@CodEscolaridade", modelo.ParticipanteCodEscolaridade);
            conexao.Conectar();
            modelo.ParticipanteCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloParticipante modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update TBParticipante set CPF = @CPF, Nome = @Nome, DataNasc = @DataNasc, " +
                "Email = @Email, Telefone = @Telefone, Cod_Escolaridade = @CodEscolaridade where Codigo = @Codigo;"

            };
            cmd.Parameters.AddWithValue("@CPF", modelo.ParticipanteCPF);
            cmd.Parameters.AddWithValue("@Nome", modelo.ParticipanteNome);
            cmd.Parameters.AddWithValue("@DataNasc", modelo.ParticipanteDataNasc);
            cmd.Parameters.AddWithValue("@Email", modelo.ParticipanteEmail);
            cmd.Parameters.AddWithValue("@Telefone", modelo.ParticipanteTelefone);
            cmd.Parameters.AddWithValue("@CodEscolaridade", modelo.ParticipanteCodEscolaridade);
            cmd.Parameters.AddWithValue("@Codigo", modelo.ParticipanteCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from TBParticipante where Codigo =" + codigo.ToString()

            };
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select P.Codigo, P.CPF, P.Nome, " +
                "P.DataNasc As DataNascimento, P.Email, P.Telefone, E.Nome AS Escolaridade, " +
                "P.Cod_Escolaridade From TBParticipante as P inner join TBEscolaridade as E on P.Cod_Escolaridade = E.Codigo where " +
                "P.DataNasc like '%" + valor + "%' OR P.Nome like '%" + valor + "%' OR P.Email like '%" + valor + 
                "%' OR P.Telefone like '%" + valor + "%' OR E.Nome like '%" + valor + "%' OR P.CPF like '%" + valor + "%'", 
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloParticipante CarregaModeloParticipante(int Codigo)
        {
            ModeloParticipante modelo = new ModeloParticipante();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "Select * form TBParticipante where Codigo =" + Codigo.ToString()
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ParticipanteCod = Convert.ToInt32(registro["Codigo"]);
                modelo.ParticipanteCPF = Convert.ToString(registro["CPF"]);
                modelo.ParticipanteNome = Convert.ToString(registro["Nome"]);
                modelo.ParticipanteDataNasc = Convert.ToDateTime(registro["DataNasc"]);
                modelo.ParticipanteEmail = Convert.ToString(registro["Email"]);
                modelo.ParticipanteTelefone = Convert.ToString(registro["Telefone"]);
                modelo.ParticipanteCodEscolaridade = Convert.ToInt32(registro["Cod_Escolaridade"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
