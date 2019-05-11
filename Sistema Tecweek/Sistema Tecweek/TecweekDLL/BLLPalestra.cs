using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecweekDAL;

namespace TecweekDLL
{
    public class BLLPalestra
    {
        private DALConexoes conexao;
        public BLLPalestra(DALConexoes cx)
        {
            this.conexao = cx;
        }
    }
}
