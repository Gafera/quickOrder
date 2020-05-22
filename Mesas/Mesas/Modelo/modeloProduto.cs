using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloProduto
    {

        private int codProduto;
        private string nomeProduto;
        private Decimal precoProduto;
        private int codTipo;
        private string imagemLocal;
        private string imagemNome;

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

        #region nomeProduto
        public string getNomeProduto()
        {
            return this.nomeProduto;
        }
        public void setNomeProduto(string nomeProduto)
        {
            this.nomeProduto = nomeProduto;
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

        #region imagemLocal
        public string getImagemLocal()
        {
            return this.imagemLocal;
        }
        public void setImagemLocal(string imagemLocal)
        {
            this.imagemLocal = imagemLocal;
        }
        #endregion

        #region ImagemNome
        public string getImagemNome()
        {
            return this.imagemNome;
        }
        public void setImagemNome(string ImagemNome)
        {
            this.imagemNome = ImagemNome;
        }
        #endregion

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
 
	

    }
}
