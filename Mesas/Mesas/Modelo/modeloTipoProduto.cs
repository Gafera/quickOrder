using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloTipoProduto
    {
        private int codTipo;
        private string nomeTipo;


        #region codTipo
        public int getCodTipo()
        {
            return this.codTipo;
        }
        public void setCodTipo(int codTipo)
        {
            this.codTipo = codTipo;
        }
        #endregion

        #region nomeTipo
        public string getNomeTipo()
        {
            return this.nomeTipo;
        }
        public void setNomeTipo(string nomeTipo)
        {
            this.nomeTipo = nomeTipo;
        }
        #endregion



    }
}
