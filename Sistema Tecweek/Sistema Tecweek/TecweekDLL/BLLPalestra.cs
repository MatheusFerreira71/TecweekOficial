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
    public class BLLPalestra
    {
        private DALConexoes conexao;
        public BLLPalestra(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPalestra modelo)
        {
            if (modelo.PalestraNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Palestra é obrigatório.");
            }
            if (modelo.PalestraMaxAlunos <= 0)
            {
                throw new Exception("O Máximo de Alunos é obrigatório.");
            }
            DALPalestra dALPalestra = new DALPalestra(conexao);
            dALPalestra.Incluir(modelo);
        }
        public void Alterar(ModeloPalestra modelo)
        {
            if (modelo.PalestraCod <= 0)
            {
                throw new Exception("O código tem que ser maior que zero.");
            }
            if (modelo.PalestraNome.Trim().Length == 0)
            {
                throw new Exception("A descrição da escolaridade é obrigatória.");
            }
            if (modelo.PalestraMaxAlunos < 0)
            {
                throw new Exception("O Máximo de Alunos é obrigatório.");
            }
            DALPalestra dALPalestra = new DALPalestra(conexao);
            dALPalestra.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALPalestra dALPalestra = new DALPalestra(conexao);
            dALPalestra.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALPalestra dALPalestra = new DALPalestra(conexao);

            return dALPalestra.Localizar(valor);
        }
        public ModeloPalestra CarregaModeloPalestra(int Codigo)
        {
            DALPalestra DALPale = new DALPalestra(conexao);

            return DALPale.CarregaModeloPalestra(Codigo);
        }
    }
}
