using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecweek_Modelo
{
    public class ModeloPalestra
    {
        private int Palestra_Cod;
        public int PalestraCod
        {
            get { return this.Palestra_Cod; }
            set { this.Palestra_Cod = value; }
        }
        private String Palestra_Nome;
        public String PalestraNome
        {
            get { return this.Palestra_Nome; }
            set { this.Palestra_Nome = value; }
        }
        private DateTime Palestra_DataHora;
        public DateTime PalestraDataHora
        {
            get { return this.Palestra_DataHora; }
            set { this.Palestra_DataHora = value; }
        }
        private int Palestra_MaxAlunos;
        public int PalestraMaxAlunos
        {
            get { return this.Palestra_MaxAlunos; }
            set { this.Palestra_MaxAlunos = value; }
        }
    }
}
