using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloFormaPagamento
    {
        private int codForma;
        private string nomeForma;

        #region codForma
        public int getCodForma()
        {
            return this.codForma;
        }
        public void setCodForma(int codForma)
        {
            this.codForma = codForma;
        }
        #endregion

        #region nomeForma
        public string getNomeForma()
        {
            return this.nomeForma;
        }
        public void setNomeForma(string nomeForma)
        {
            this.nomeForma = nomeForma;
        }
        #endregion

    }
}
