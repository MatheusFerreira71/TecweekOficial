using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecweek_Modelo
{
    public class ModeloCadastrarNaPalestra
    {
        private int CPalestra_Cod;
        public int CPalestraCod
        {
            get { return this.CPalestra_Cod; }
            set { this.CPalestra_Cod = value; }
        }
        private int CPalestra_Cod_Aluno;
        public int CPalestraCodAluno
        {
            get { return this.CPalestra_Cod_Aluno; }
            set { this.CPalestra_Cod_Aluno = value; }
        }
        private int CPalestra_Cod_Palestra;
        public int CPalestraCodPalestra
        {
            get { return this.CPalestra_Cod_Palestra; }
            set { this.CPalestra_Cod_Palestra = value; }
        }
    }
}
