using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesas.Modelo;
using Mesas.Controle;
using MySql.Data.MySqlClient;
namespace Mesas.Controle
{
    class controlPedido
    {

        public MySqlDataReader pesquisaPedido()
        {
            MySqlDataReader dados = null;

            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();


            MySqlCommand comando = new MySqlCommand("SELECT codPedido, cliente, nomeForma,codMesa, valorTotal, data, andamento FROM pedido INNER JOIN cliente ON pedido.codCliente = cliente.codCliente INNER JOIN formapagamento ON pedido.codFormaPagamento = formapagamento.codForma", obj.obterConexao());


            dados = comando.ExecuteReader();

            return dados;
        }
        public MySqlDataReader pesquisaPedidoFinalizado()
        {
            MySqlDataReader dados = null;

            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();


            MySqlCommand comando = new MySqlCommand("SELECT codPedido, cliente, nomeForma,codMesa, valorTotal, data, andamento FROM pedido INNER JOIN cliente ON pedido.codCliente = cliente.codCliente INNER JOIN formapagamento ON pedido.codFormaPagamento = formapagamento.codForma where andamento = 'Finalizado'", obj.obterConexao());


            dados = comando.ExecuteReader();

            return dados;
        }

        public MySqlDataReader pesquisaItens(int codPedido)
        {
            MySqlDataReader dados = null;

            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();


            MySqlCommand comando = new MySqlCommand("select nomeProduto, quantidade, nome from itensPedido INNER JOIN produto ON itenspedido.codProduto = produto.codProduto inner join estadoAlimento ON itenspedido.pronto = estadoAlimento.codEstado where codPedido ="+codPedido+"  ORDER BY nomeProduto ASC ", obj.obterConexao());


            dados = comando.ExecuteReader();

            return dados;
        }
        
    }
}
