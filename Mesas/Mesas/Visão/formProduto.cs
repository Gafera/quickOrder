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
using System.IO;
using MySql.Data.MySqlClient;
using Mesas.Modelo;

namespace Mesas.Visão
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }
        string imagemDestino = "";
        string imagemNome = "";
        private void clickImagem(object sender, EventArgs e)
        {

            conexoesBanco conn = new conexoesBanco();
            String imagemLocal = "";
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.pgn)| All files(*.*)|*.*|";
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                imagemLocal = dialog.FileName;
                pictureBox1.ImageLocation = imagemLocal;

                FileInfo fileInfo = new FileInfo(imagemLocal);
                //Mostra o nome do arquivo
                imagemNome = fileInfo.Name;
                imagemDestino = @"C:\wamp64\www\quickOrder\imagens\" + imagemNome;

                // To move a file or folder to a new location:
                System.IO.File.Copy(imagemLocal, imagemDestino);
                modeloProduto mProduto = new modeloProduto();
                
                  
            }
            }
            catch(Exception) {
                MessageBox.Show("erro");
            }
        }

        private void loadProduto(object sender, EventArgs e)
        {
            controlProduto cProduto = new controlProduto();
            MySqlDataReader dados = cProduto.pesquisaProduto();
            DataTable pro = new DataTable();
            pro.Load(dados);
            comboBox1.DataSource = pro;
            comboBox1.DisplayMember = "nomeTipo";
            comboBox1.ValueMember = "codTipo";

                   
        }

        private void btnSalvar(object sender, EventArgs e)
        {
            string resp;
            modeloProduto mProduto = new modeloProduto();
            controlProduto cProduto = new controlProduto();
            //pega os valores do form e grava os atributos
            mProduto.setImagemLocal(imagemDestino);
            mProduto.setImagemNome(imagemNome);
            mProduto.setNomeProduto(textBox1.Text);
            mProduto.setPrecoProduto(Convert.ToDecimal(textBox2.Text));
            mProduto.setCodTipo(Convert.ToInt32(comboBox1.SelectedValue));
            
            

            //grava os valores dos atributos (modeloCidade) na tabela do BD
            resp = cProduto.cadastraProduto(mProduto);
            //mensagem informando se gravou ou o erro que ocorreu caso não consiga gravar no banco
            MessageBox.Show(resp);
            MessageBox.Show(mProduto.getImagemNome());
            MessageBox.Show(mProduto.getImagemLocal()); 
        }
    }
}
