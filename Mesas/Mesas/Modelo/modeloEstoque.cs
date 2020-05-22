using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloEstoque
    {
        private int codEstoque;
        private string nomeEstoque;
        private float quantidade;
        private int codMedida;


        #region codEstoque
        public int getCodEstoque()
        {
            return this.codEstoque;
        }
        public void setCodEstoque(int codEstoque)
        {
            this.codEstoque = codEstoque;
        }
        #endregion

        #region nomeEstoque
        public string getNomeEstoque()
        {
            return this.nomeEstoque;
        }
        public void setNomeEstoque(string nomeEstoque)
        {
            this.nomeEstoque = nomeEstoque;
        }
        #endregion

        #region quantidade
        public float getQuantidade()
        {
            return this.quantidade;
        }
        public void setQuantidade(float quantidade)
        {
            this.quantidade = quantidade;
        }
        #endregion

        #region codMedida
        public int getCodMedida()
        {
            return this.codMedida;
        }
        public void setCodMedida(int codMedida)
        {
            this.codMedida = codMedida;
        }
        #endregion
        

        
    }
}
