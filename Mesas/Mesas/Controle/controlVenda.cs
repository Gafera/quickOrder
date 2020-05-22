using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Mesas.Controle
{
    class controlVenda
    {
        public MySqlDataReader pesquisaDias()
        {
            MySqlDataReader dados = null;
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();

            MySqlCommand comando = new MySqlCommand("SELECT codPedido, cliente, nomeForma, valorTotal, data, andamento FROM pedido INNER JOIN cliente ON pedido.codCliente = cliente.codCliente INNER JOIN formapagamento ON pedido.codFormaPagamento = formapagamento.codForma ", conn);


            dados = comando.ExecuteReader();

            return dados;
        }
        public MySqlDataReader procuraCli(string nome)
        {
            conexoesBanco obj = new conexoesBanco();


            MySqlDataReader dados = null;
            MySqlConnection conn = obj.obterConexao();
            MySqlCommand comando = new MySqlCommand("select codCliente, cliente from cliente where cliente like '" + nome + "%';", conn);
            dados = comando.ExecuteReader();


            return dados;
        }

        public MySqlDataReader procuraVendasCli(int cod)
        {
            conexoesBanco obj = new conexoesBanco();


            MySqlDataReader dados = null;
            MySqlConnection conn = obj.obterConexao();
            MySqlCommand comando = new MySqlCommand("SELECT codPedido, data, valorTotal, codMesa from pedido WHERE codCliente =" +cod+";", conn);
            dados = comando.ExecuteReader();


            return dados;
        }

        public MySqlDataReader procuraQuantidadePro(int cod)
        {
            conexoesBanco obj = new conexoesBanco();


            MySqlDataReader dados = null;
            MySqlConnection conn = obj.obterConexao();
            MySqlCommand comando = new MySqlCommand("SELECT SUM(quantidade) from itenspedido WHERE codProduto = "+cod+" LIMIT 10 ", conn);
            dados = comando.ExecuteReader();


            return dados;
        }
        public MySqlDataReader pesquisaProduto()
        {
            MySqlDataReader dados = null;
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();

            MySqlCommand comando = new MySqlCommand("select * from produto ", conn);


            dados = comando.ExecuteReader();

            return dados;
        }
    }
}
