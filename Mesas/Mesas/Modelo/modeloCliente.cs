using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Modelo
{
    class modeloCliente
    {
        private int codCliente;
        private string cliente;
        private string email;
        private DateTime dataNascimento;
        private string telefone;
        private string senha;

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

        #region cliente
        public string getCliente()
        {
            return this.cliente;
        }
        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
        #endregion

        #region email
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        #endregion

        #region dataNascimento
        public DateTime getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
        #endregion

        #region telefone
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        #endregion

        #region senha
        public string getSenha()
        {
            return this.senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        #endregion


      


    }

}
