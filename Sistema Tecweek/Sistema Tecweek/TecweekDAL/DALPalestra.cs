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
    public class DALPalestra
    {
        private DALConexoes conexao;
        public DALPalestra(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPalestra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into TBPalestra(Nome, Data_Hora, Max_Alunos) values (@nome, @dataHora, @maxAlunos); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.PalestraNome);
            cmd.Parameters.AddWithValue("@dataHora", modelo.PalestraDataHora);
            cmd.Parameters.AddWithValue("@maxAlunos", modelo.PalestraMaxAlunos);
            conexao.Conectar();
            modelo.PalestraCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloPalestra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update TBPalestra set Nome = @nome, Data_Hora = @dataHora, Max_Alunos = @maxAlunos where Codigo = @codigo;"

            };
            cmd.Parameters.AddWithValue("@nome", modelo.PalestraNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.PalestraCod);
            cmd.Parameters.AddWithValue("@dataHora", modelo.PalestraDataHora);
            cmd.Parameters.AddWithValue("@maxAlunos", modelo.PalestraMaxAlunos);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from TBPalestra where Codigo =" + codigo.ToString()
            };
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBPalestra where Nome like '%" + valor
                + "%' OR Data_Hora like '%" + valor + "%' OR Max_Alunos like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloPalestra CarregaModeloPalestra(int Codigo)
        {
            ModeloPalestra modelo = new ModeloPalestra();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "Select * form TBPalestra where Codigo =" + Codigo.ToString()
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PalestraCod = Convert.ToInt32(registro["Codigo"]);
                modelo.PalestraNome = Convert.ToString(registro["Nome"]);
                modelo.PalestraDataHora = Convert.ToDateTime(registro["Data_Hora"]);
                modelo.PalestraMaxAlunos = Convert.ToInt32(registro["Max_Alunos"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
