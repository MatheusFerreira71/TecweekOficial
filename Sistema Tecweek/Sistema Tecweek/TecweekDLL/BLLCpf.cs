using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecweekDAL;
using Tecweek_Modelo;
using System.Data;

namespace TecweekDLL
{
    public class BLLCpf
    {
        private DALConexoes conexao;
        public BLLCpf(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCPF modelo)
        {
            if (modelo.CpfNome.Trim().Length == 0)
            {
                throw new Exception("O CPF é obrigatório.");
            }
            

            DALCpf DALCpf = new DALCpf(conexao);

            DALCpf.Incluir(modelo);

        }
        public void Alterar(ModeloCPF modelo)
        {
            if (modelo.CpfCod <= 0)
            {
                throw new Exception("O código tem que ser maior que zero.");
            }
            if (modelo.CpfNome.Trim().Length == 0)
            {
                throw new Exception("O CPF é obrigatório.");
            }
            

            DALCpf DALCpf = new DALCpf(conexao);

            DALCpf.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCpf DALCpf = new DALCpf(conexao);

            DALCpf.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCpf DALCpf = new DALCpf(conexao);

            return DALCpf.Localizar(valor);
        }
        public ModeloCPF CarregaModeloCpf(int Codigo)
        {
            DALCpf DALCpf = new DALCpf(conexao);

            return DALCpf.CarregaModeloCPF(Codigo);
        }
    }
}
