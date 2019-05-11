using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecweek_Modelo;
using System.Data.SqlClient;
using System.Data;

namespace TecweekDAL
{
    public class DALCpf
    {
        private DALConexoes Conexao;
        public DALCpf(DALConexoes cx)
        {
            this.Conexao = cx;
        }
        public void Incluir(ModeloCPF modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = Conexao.ObjetoConexao,
                CommandText = "insert into TB_CPF(CPF) values (@CPF); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@CPF", modelo.CpfNome);
            Conexao.Conectar();
            modelo.CpfCod = Convert.ToInt32(cmd.ExecuteScalar());
            Conexao.Desconectar();
        }
        public void Alterar(ModeloCPF modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = Conexao.ObjetoConexao,
                CommandText = "update TB_CPF set CPF = @CPF where Codigo = @codigo;"

            };
            cmd.Parameters.AddWithValue("@CPF", modelo.CpfNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CpfCod);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = Conexao.ObjetoConexao,
                CommandText = "delete from TB_CPF where Codigo =" + codigo.ToString()

            };
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TB_CPF where CPF" +
                " like '%" + valor
                + "%'", Conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCPF CarregaModeloCPF(int Codigo)
        {
            ModeloCPF modelo = new ModeloCPF();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = Conexao.ObjetoConexao,
                CommandText = "Select * form TB_CPF where Codigo =" + Codigo.ToString()
            };
            Conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CpfCod = Convert.ToInt32(registro["Codigo"]);
                modelo.CpfNome = Convert.ToString(registro["Nome"]);
            }
            Conexao.Desconectar();
            return modelo;
        }
        // Talvez eu não use esse método para essa tabela, se usar eu mudo. 
    }
}
