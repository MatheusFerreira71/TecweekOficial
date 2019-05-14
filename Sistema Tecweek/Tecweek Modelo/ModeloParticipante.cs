using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecweek_Modelo
{
    public class ModeloParticipante
    {
        private int Participante_Cod;
        public int ParticipanteCod
        {
            get { return this.Participante_Cod; }
            set { this.Participante_Cod = value; }
        }
        private int Participante_Cod_CPF;
        public int ParticipanteCodCPF
        {
            get { return this.Participante_Cod_CPF; }
            set { this.Participante_Cod_CPF = value; }
        }
        private String Participante_Nome;
        public String ParticipanteNome 
        { 
            get { return this.Participante_Nome; }
            set { this.Participante_Nome = value; }
        }
        private DateTime Participante_Data_Nasc;
        public DateTime ParticipanteDataNasc
        {
            get { return this.Participante_Data_Nasc; }
            set { this.Participante_Data_Nasc = value; }
        }
        private String Participante_Email;
        public String ParticipanteEmail
        {
            get { return this.Participante_Email; }
            set { this.Participante_Email = value; }
        }
        private String Participante_Telefone;
        public String ParticipanteTelefone
        {
            get { return this.Participante_Telefone; }
            set { this.Participante_Telefone = value; }
        }
        private int Participante_Cod_Escolaridade;
        public int ParticipanteCodEscolaridade
        {
            get { return this.Participante_Cod_Escolaridade; }
            set { this.Participante_Cod_Escolaridade = value; }
        }
    }
}
