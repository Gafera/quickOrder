using Mesas.Controle;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesas.Visão
{
    public partial class pedirContas : Form
    {
        public pedirContas()
        {
            InitializeComponent();
        }

        private void carrega(object sender, EventArgs e)
        {
            controlPedido obj = new controlPedido();
            obj.pesquisaPedidoFinalizado();

            dataGridView1.Columns.Clear();
            controlPedido cPedido = new controlPedido();
            MySqlDataReader dados = cPedido.pesquisaPedidoFinalizado();

            int col = dados.FieldCount;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Código Pedido";
            dataGridView1.Columns[1].Name = "Cliente";
            dataGridView1.Columns[2].Name = "Forma de pagamento";
            dataGridView1.Columns[3].Name = "Mesa";
            dataGridView1.Columns[4].Name = "Valor Total";
            dataGridView1.Columns[5].Name = "Data";
            dataGridView1.Columns[6].Name = "Andamento";




            string[] tabela = new string[col];
            while (dados.Read())
            {
                for (int i = 0; i < col; i++)
                {
                    tabela[i] = dados.GetValue(i).ToString();
                }
                dataGridView1.Rows.Add(tabela);
            }

        }
    }
}
