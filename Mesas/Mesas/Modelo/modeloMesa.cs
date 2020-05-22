using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloMesa
    {
        private int numeroMesa;
        private string ocupado;

        #region numeroMesa
        public int getNumeroMesa()
        {
            return this.numeroMesa;
        }
        public void setNumeroMesa(int numeroMesa)
        {
            this.numeroMesa = numeroMesa;
        }
        #endregion

        #region ocupado
        public string getOcupado()
        {
            return this.ocupado;
        }
        public void setOcupado(string ocupado)
        {
            this.ocupado = ocupado;
        }
        #endregion

    }
}
