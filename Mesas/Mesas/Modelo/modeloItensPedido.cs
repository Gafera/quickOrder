using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloItensPedido
    {

        private static int codPedido = 0;
        private int codProduto;
        private Decimal precoProduto;
        private int quantidade;


        #region codPedido
        public int getCodPedido()
        {
            return codPedido;
        }
        public static void setCodPedido(int codPedido)
        {
           codPedido = codPedido;
        }
        #endregion

        #region codProduto
        public int getCodProduto()
        {
            return this.codProduto;
        }
        public void setCodProduto(int codProduto)
        {
            this.codProduto = codProduto;
        }
        #endregion

        #region precoProduto
        public Decimal getPrecoProduto()
        {
            return this.precoProduto;
        }
        public void setPrecoProduto(Decimal precoProduto)
        {
            this.precoProduto = precoProduto;
        }
        #endregion

        #region quantidade
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        #endregion




    }
}
