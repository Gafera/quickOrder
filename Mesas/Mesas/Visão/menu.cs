using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Mesas.Controle;
using Mesas.Visão;

namespace Mesas.Visão
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
           /* controlePedido obj = new controlePedido();
            obj.pesquisaPedido();

            dataGridView1.Columns.Clear();
            controlePedido cPedido = new controlePedido();
            MySqlDataReader dados = cPedido.pesquisaPedido();

            int col = dados.FieldCount;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Codigo Pedido";
            dataGridView1.Columns[1].Name = "Cod Cliente";
            dataGridView1.Columns[2].Name = "Forma de pagamento";
            dataGridView1.Columns[3].Name = "Mesa";
            dataGridView1.Columns[4].Name = "Valor Total";
            dataGridView1.Columns[5].Name = "Data";



            string[] tabela = new string[col];
            while (dados.Read())
            {
                for (int i = 0; i < col; i++)
                {
                    tabela[i] = dados.GetValue(i).ToString();
                }
                dataGridView1.Rows.Add(tabela);
            }
           */
        }

        private void conectaClick(object sender, EventArgs e)
        {
           
        }

        private void verMesa(object sender, EventArgs e)
        {
            Form2 mesas = new Form2();
            mesas.ShowDialog();
        }

        private void clickVisao(object sender, EventArgs e)
        {
            visaoGeral visaoForm = new visaoGeral();
            visaoForm.ShowDialog();
        }

        private void click(object sender, EventArgs e)
        {
          
        }

        private void clickFinanças(object sender, EventArgs e)
        {
            formControleFinanceiro visaoForm = new formControleFinanceiro();
            visaoForm.ShowDialog();
        }

        private void clickProduto(object sender, EventArgs e)
        {
            Produto visaoForm = new Produto();
            visaoForm.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pedidosConta(object sender, EventArgs e)
        {
            pedirContas visaoForm = new pedirContas();
            visaoForm.ShowDialog();
        }
    }
}
