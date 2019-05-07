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
    public class DALEscolaridade
    {
        private DALConexoes conexao;
        public DALEscolaridade(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(modeloEscolaridade modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into TBEscolaridade(Nome) values (@nome); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.escNome);
            conexao.Conectar();
            modelo.escCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(modeloEscolaridade modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update TBEscolaridade set Nome = @nome where Codigo = @codigo;"

            };
            cmd.Parameters.AddWithValue("@nome", modelo.escNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.escCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from TBEscolaridade where Codigo ="+ codigo.ToString()

            };
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBEscolaridade where Nome like '%" + valor
                + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public modeloEscolaridade CarregaModeloEscolaridade(int Codigo)
        {
            modeloEscolaridade modelo = new modeloEscolaridade();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "Select * form TBEscolaridade where Codigo =" + Codigo.ToString()
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.escCod = Convert.ToInt32(registro["Codigo"]);
                modelo.escNome = Convert.ToString(registro["Nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
