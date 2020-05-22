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
using Mesas.Modelo;
using Mesas.Visão;

namespace Mesas.Visão
{

    public partial class visaoGeral : Form
    {
        int codPedido;
        int cont = 0;
        
        controlPedido ctr = new controlPedido();
        modeloItensPedido model = new modeloItensPedido();
                
        public visaoGeral()
        {
            InitializeComponent();
            btnVoltar.Enabled = false;
        }

        private void carregaPedido(object sender, EventArgs e)
        {
            controlPedido obj = new controlPedido();
            obj.pesquisaPedido();

            dataGridView1.Columns.Clear();
            controlPedido cPedido = new controlPedido();
            MySqlDataReader dados = cPedido.pesquisaPedido();

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

        private void envia(object sender, EventArgs e)
        {
           
                DialogResult res = MessageBox.Show("Deseja visualizar esse pedido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {

                    codPedido = (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    dataGridView1.Columns.Clear(); //Remover as colunas
                    dataGridView1.Rows.Clear();
                   
                    MySqlDataReader dados = ctr.pesquisaItens(Convert.ToInt32(codPedido));


                    int col = dados.FieldCount;
                    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].Name = "Produto";
                    dataGridView1.Columns[1].Name = "Quantidade";
                    dataGridView1.Columns[2].Name = "Estado";

                   



                    string[] tabela = new string[col];
                    while (dados.Read())
                    {
                        for (int i = 0; i < col; i++)
                        {
                            tabela[i] = dados.GetValue(i).ToString();
                        }
                        dataGridView1.Rows.Add(tabela);
                    }
                    btnVoltar.Enabled = true;
         
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clickVoltar(object sender, EventArgs e)
        {
            controlPedido obj = new controlPedido();
            obj.pesquisaPedido();

            dataGridView1.Columns.Clear();
            controlPedido cPedido = new controlPedido();
            MySqlDataReader dados = cPedido.pesquisaPedido();

            int col = dados.FieldCount;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Código Pedido";
            dataGridView1.Columns[1].Name = "Cliente";
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
            btnVoltar.Enabled = false;
        }

        
    }
}
