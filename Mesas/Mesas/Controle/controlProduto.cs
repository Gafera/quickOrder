using Mesas.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesas.Controle
{
    class controlProduto
    {
        public string cadastraProduto(modeloProduto produto)
        {
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();
            MySqlCommand comando = new MySqlCommand("insert into produto(nomeProduto, precoProduto, codTipo, imagemLocal, nomeImagem) values(@nomeProduto, @precoProduto, @codTipo, @imagemLocal, @imagemNome);", conn);

            try
            {

                //comando Parameters.AddWithValue adiciona o valor a ser gravado no 
                //banco copiando diretamente do atributo na classe modelo
                comando.Parameters.AddWithValue("@nomeProduto", produto.getNomeProduto());
                comando.Parameters.AddWithValue("@precoProduto", produto.getPrecoProduto());
                comando.Parameters.AddWithValue("@codTipo", produto.getCodTipo());
                comando.Parameters.AddWithValue("@imagemLocal", produto.getImagemLocal());
                comando.Parameters.AddWithValue("@imagemNome", produto.getImagemNome());
                //executa o comando SQL
                comando.ExecuteNonQuery();
                return "DADOS SALVOS COM SUCESSO";
            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }
        }
        public MySqlDataReader pesquisaProduto()
        {
            MySqlDataReader dados = null;
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();

            MySqlCommand comando = new MySqlCommand("select codTipo, nomeTipo from tipoProduto;", conn);


            dados = comando.ExecuteReader();

            return dados;
        }
    }
}
