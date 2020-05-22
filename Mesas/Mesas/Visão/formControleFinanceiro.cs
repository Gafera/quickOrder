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
    public partial class formControleFinanceiro : Form
    {
        public formControleFinanceiro()
        {
            InitializeComponent();
        }

        private void clickVendas(object sender, EventArgs e)
        {
            vendasDiarias visao = new vendasDiarias();
            visao.ShowDialog();
        }

        private void clickProduVendi(object sender, EventArgs e)
        {
            produtoQtd visao = new produtoQtd();
            visao.ShowDialog();
        }
    }
}
