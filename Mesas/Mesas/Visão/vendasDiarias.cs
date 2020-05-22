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

namespace Mesas.Visão
{
    public partial class vendasDiarias : Form
    {
        public vendasDiarias()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        int codCliente;
        int codPedido;
        controlPedido ctrPedido = new controlPedido();
        private void carregaVendas(object sender, EventArgs e)
        {
            
        }

        private void pesquisaCliente(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            Mesas.Controle.controlVenda cVenda = new Mesas.Controle.controlVenda();
            MySqlDataReader dados = cVenda.procuraCli(textBox1.Text);

            int col = dados.FieldCount;
            dataGridView3.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView3.ColumnCount = 2;
            dataGridView3.Columns[0].Name = "Codigo";
            dataGridView3.Columns[1].Name = "Nome";
            



            string[] tabela = new string[col];
            while (dados.Read())
            {
                for (int i = 0; i < col; i++)
                {
                    tabela[i] = dados.GetValue(i).ToString();
                }
                dataGridView3.Rows.Add(tabela);
            }
        }

        private void clickDataGrid(object sender, EventArgs e)
        {
            string[] dados = new string[3];// define quantidade de colunas de uma linha 
            dados[0] = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dados[1] = dataGridView3.CurrentRow.Cells[1].Value.ToString();



            dataGridView3.DefaultCellStyle.Font = new Font("Arial", 11);

            //textBox3.Text

            string cliente = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            //DialogResult res = MessageBox.Show("Deseja adicionar este cliente:" + cliente, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (res == DialogResult.Yes)
            //{
                codCliente = Convert.ToInt32(dados[0]);
                textBox1.Text = dados[1];

            //}
        }

        private void clickPesquisa(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            Mesas.Controle.controlVenda cVenda = new Mesas.Controle.controlVenda();
            MessageBox.Show(Convert.ToString(codCliente));
            MySqlDataReader dados = cVenda.procuraVendasCli(codCliente);


            int col = dados.FieldCount;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Código Pedido";
            dataGridView1.Columns[1].Name = "Data";
            dataGridView1.Columns[2].Name = "Valor Total";
            dataGridView1.Columns[3].Name = "Númeração da mesa";
           



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

        private void envia(object sender, EventArgs e)
        {



            DialogResult res = MessageBox.Show("Deseja visualizar esse pedido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {

                codPedido = (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                dataGridView1.Columns.Clear(); //Remover as colunas
                dataGridView1.Rows.Clear();

                MySqlDataReader dados = ctrPedido.pesquisaItens(Convert.ToInt32(codPedido));


                int col = dados.FieldCount;
                dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Produto";
                dataGridView1.Columns[1].Name = "Quantidade";




                string[] tabela = new string[col];
                while (dados.Read())
                {
                    for (int i = 0; i < col; i++)
                    {
                        tabela[i] = dados.GetValue(i).ToString();
                    }
                    dataGridView1.Rows.Add(tabela);
                }
                button2.Enabled = true;
                
            }
        }

        private void clickVoltar(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            Mesas.Controle.controlVenda cVenda = new Mesas.Controle.controlVenda();
            MessageBox.Show(Convert.ToString(codCliente));
            MySqlDataReader dados = cVenda.procuraVendasCli(codCliente);


            int col = dados.FieldCount;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Código Pedido";
            dataGridView1.Columns[1].Name = "Data";
            dataGridView1.Columns[2].Name = "Valor Total";
            dataGridView1.Columns[3].Name = "Númeração da mesa";




            string[] tabela = new string[col];
            while (dados.Read())
            {
                for (int i = 0; i < col; i++)
                {
                    tabela[i] = dados.GetValue(i).ToString();
                }
                dataGridView1.Rows.Add(tabela);
            }
            button2.Enabled = false;
        }
    }
}
