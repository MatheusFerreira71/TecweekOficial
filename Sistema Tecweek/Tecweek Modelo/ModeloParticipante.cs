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
    }
}
