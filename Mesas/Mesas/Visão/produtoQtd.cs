using Mesas.Controle;
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

namespace Mesas.Visão
{
    public partial class produtoQtd : Form
    {
        public produtoQtd()
        {
            InitializeComponent();
        }

        private void carregaCombo(object sender, EventArgs e)
        {
            controlVenda cCidade = new controlVenda();


            MySqlDataReader dados = cCidade.pesquisaProduto();

            DataTable produto = new DataTable();

            produto.Load(dados);


            comboBox1.DataSource = produto;

            comboBox1.DisplayMember = "nomeProduto";

            comboBox1.ValueMember = "codProduto";
        }

        private void clickVer(object sender, EventArgs e)
        {
            int codProduto;
            codProduto = Convert.ToInt32(comboBox1.SelectedValue);
            

        }
    }
}
