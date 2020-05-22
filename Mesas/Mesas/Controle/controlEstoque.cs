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
    class controlEstoque
    {
        public string cadastraEstoque(modeloEstoque estoque)
        {
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();
            MySqlCommand comando = new MySqlCommand("insert into estoque(nomeEstoque, quantidade, codMedida) values(@nomeEstoque, @quantidade, @codMedida);", conn);

            try
            {

                //comando Parameters.AddWithValue adiciona o valor a ser gravado no 
                //banco copiando diretamente do atributo na classe modelo
                comando.Parameters.AddWithValue("@nomeEstoque", estoque.getNomeEstoque());
                comando.Parameters.AddWithValue("@quantidade", estoque.getQuantidade());
                comando.Parameters.AddWithValue("@codMedida", estoque.getCodMedida());
                //executa o comando SQL
                comando.ExecuteNonQuery();
                return "DADOS SALVOS COM SUCESSO";
            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }

        }

        public MySqlDataReader pesquisaMedida()
        {
            MySqlDataReader dados = null;
            conexoesBanco obj = new conexoesBanco();

            MySqlConnection conn = obj.obterConexao();

            MySqlCommand comando = new MySqlCommand("select codMedida, nomeMedida from medida;", conn);


            dados = comando.ExecuteReader();

            return dados;
        }

        
    }
}
