using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecweek_Modelo
{
    public class modeloEscolaridade
    {
        private int esc_Cod;
        public int escCod
        {
            get { return this.esc_Cod; }
            set { this.esc_Cod = value; }
        }

        private String esc_Nome;
        public String escNome
        {
            get { return this.esc_Nome; }
            set { this.esc_Nome = value; }
        }
    }
}
