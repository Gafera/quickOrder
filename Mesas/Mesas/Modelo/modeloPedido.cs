using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloPedido
    {
     
        private int codPedido;
        private int codCliente;
        private int codFormaPagamento;
        private int codMesa;
        private Decimal valorTotal;


        #region codPedido
        public int getCodPedido()
        {
            return this.codPedido;
        }
        public void setCodPedido(int codPedido)
        {
            this.codPedido = codPedido;
        }
        #endregion

        #region codCliente
        public int getCodCliente()
        {
            return this.codCliente;
        }
        public void setCodCliente(int codCliente)
        {
            this.codCliente = codCliente;
        }
        #endregion

        #region codFormaPagamento
        public int getCodFormaPagamento()
        {
            return this.codFormaPagamento;
        }
        public void setCodFormaPagamento(int codFormaPagamento)
        {
            this.codFormaPagamento = codFormaPagamento;
        }
        #endregion

        #region codMesa
        public int getCodMesa()
        {
            return this.codMesa;
        }
        public void setCodMesa(int codMesa)
        {
            this.codMesa = codMesa;
        }
        #endregion

        #region valorTotal
        public Decimal getValorTotal()
        {
            return this.valorTotal;
        }
        public void setValorTotal(Decimal valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        #endregion

        

    

	
	
    }
}
