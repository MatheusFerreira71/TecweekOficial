using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecweek_Modelo;
using TecweekDAL;
namespace TecweekDLL
{
    public class BLLEscolaridade
    {
        private DALConexoes conexao;
        public BLLEscolaridade(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(modeloEscolaridade modelo)
        {
            if(modelo.escNome.Trim().Length == 0)
            {
                throw new Exception("A descrição da escolaridade é obrigatória.");
            }

            DALEscolaridade DALEsc = new DALEscolaridade(conexao);

            DALEsc.Incluir(modelo);
            
        }
        public void Alterar(modeloEscolaridade modelo)
        {
            if (modelo.escCod <= 0)
            {
                throw new Exception("O código tem que ser maior que zero.");
            }
            if (modelo.escNome.Trim().Length == 0)
            {
                throw new Exception("A descrição da escolaridade é obrigatória.");
            }

            DALEscolaridade DALEsc = new DALEscolaridade(conexao);

            DALEsc.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALEscolaridade DALEsc = new DALEscolaridade(conexao);

            DALEsc.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALEscolaridade DALEsc = new DALEscolaridade(conexao);

            return DALEsc.Localizar(valor);
        }
        public modeloEscolaridade CarregaModeloEscolaridade(int Codigo)
        {
            DALEscolaridade DALEsc = new DALEscolaridade(conexao);

            return DALEsc.CarregaModeloEscolaridade(Codigo);
        }
    }
}
