using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecweek_Modelo
{
    public class ModeloCPF
    {
        private int CPF_Cod;
        public int CpfCod
        {
            get { return this.CPF_Cod; }
            set { this.CPF_Cod = value; }
        }

        private String Cpf_Nome;
        public String CpfNome
        {
            get { return this.Cpf_Nome; }
            set { this.Cpf_Nome = value; }
        }
    }
}
