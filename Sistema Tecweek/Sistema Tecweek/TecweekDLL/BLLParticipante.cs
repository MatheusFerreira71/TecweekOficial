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
    public class BLLParticipante
    {
        private DALConexoes conexao;
        public BLLParticipante(DALConexoes cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParticipante modelo)
        {
            if (modelo.ParticipanteNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Participante é obrigatório.");
            }
            if (modelo.ParticipanteEmail.Trim().Length == 0)
            {
                throw new Exception("O E-mail do Participante é obrigatório é obrigatório.");
            }
            if (modelo.ParticipanteTelefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do Participante é obrigatório.");
            }
            if (modelo.ParticipanteCodCPF < 0)
            {
                throw new Exception("O CPF do Participante é obrigatório.");
            }
            if (modelo.ParticipanteCodCPF < 0)
            {
                throw new Exception("A Escolaridade do Participante é obrigatória.");
            }
            DALParticipante DalParti = new DALParticipante(conexao);
            DalParti.Incluir(modelo);
        }
        public void Alterar(ModeloParticipante modelo)
        {
            if (modelo.ParticipanteNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Participante é obrigatório.");
            }
            if (modelo.ParticipanteEmail.Trim().Length == 0)
            {
                throw new Exception("O E-mail do Participante é obrigatório é obrigatório.");
            }
            if (modelo.ParticipanteTelefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do Participante é obrigatório.");
            }
            if (modelo.ParticipanteCodCPF < 0)
            {
                throw new Exception("O CPF do Participante é obrigatório.");
            }
            if (modelo.ParticipanteCodCPF < 0)
            {
                throw new Exception("A Escolaridade do Participante é obrigatória.");
            }
            DALParticipante DALParti = new DALParticipante(conexao);
            DALParti.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALParticipante DALParti = new DALParticipante(conexao);
            DALParti.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALParticipante DALParti = new DALParticipante(conexao);
            return DALParti.Localizar(valor);
        }
        public ModeloParticipante CarregaModeloParticipante(int Codigo)
        {
            DALParticipante DALParti = new DALParticipante(conexao);
            return DALParti.CarregaModeloParticipante(Codigo);
        }
    }
}
