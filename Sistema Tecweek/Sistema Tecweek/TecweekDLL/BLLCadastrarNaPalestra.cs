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
    public class BLLCadastrarNaPalestra
    {
        private DALConexoes conexao;
        public BLLCadastrarNaPalestra(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCadastrarNaPalestra modelo)
        {
            if (modelo.CPalestraCodAluno <= 0)
            {
                throw new Exception("O nome da Participante é obrigatório.");
            }
            if (modelo.CPalestraCodPalestra <= 0)
            {
                throw new Exception("A Palestra é obrigatória.");
            }
            DALCadastroNaPalestra DALCPales = new DALCadastroNaPalestra(conexao);
            DALCPales.Incluir(modelo);
        }
        public void Alterar(ModeloCadastrarNaPalestra modelo)
        {
            if (modelo.CPalestraCod <= 0)
            {
                throw new Exception("Nenhum registro Selecionado.");
            }
            if (modelo.CPalestraCodAluno <= 0)
            {
                throw new Exception("O nome da Participante é obrigatório.");
            }
            if (modelo.CPalestraCodPalestra <= 0)
            {
                throw new Exception("A Palestra é obrigatória.");
            }
            DALCadastroNaPalestra DALCPales = new DALCadastroNaPalestra(conexao);
            DALCPales.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCadastroNaPalestra DALCPales = new DALCadastroNaPalestra(conexao);
            DALCPales.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCadastroNaPalestra DALCPales = new DALCadastroNaPalestra(conexao);
            return DALCPales.Localizar(valor);
        }
        public ModeloCadastrarNaPalestra CarregaModeloCPalestra(int Codigo)
        {
            DALCadastroNaPalestra DALCPales = new DALCadastroNaPalestra(conexao);
            return DALCPales.CarregaModeloCPalestra(Codigo);
        }
        public bool HaVagas(int Palestra)
        {
            BLLCadastrarNaPalestra BLLCPales = new BLLCadastrarNaPalestra(conexao);
            return BLLCPales.HaVagas(Palestra);
        }
    }
}
