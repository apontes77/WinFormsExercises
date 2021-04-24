using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbProdutos.Text = "[ Selecione ]";
            CmbLocal.Text = "[ Selecione ]";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LbFrete.Text = "0";
            LbTotal.Text = "0";
            LbValor.Text = "0";
            CmbLocal.Text = "[ Selecione ]";
            CmbProdutos.Text = "[ Selecione ]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if(CmbProdutos.SelectedIndex.Equals(0))
            {
                result = MessageBox.Show("Selecione um produto para continuar.",
                    "Selecione um Produto", MessageBoxButtons.OK);
            }
            else if ( CmbLocal.SelectedIndex.Equals(0))
            {
                result = MessageBox.Show("Selecione um local de entrega para continuar.",
                    "Selecione um local de entrega", MessageBoxButtons.OK);
            }
            else
            {
                double total;
                total = Convert.ToDouble(LbValor.Text.Substring(2)) + Convert.ToDouble(LbFrete.Text.Substring(2));
                LbTotal.Text = string.Format("{0:C}", total);
            }
        }

        private void CmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbProdutos.SelectedIndex)
            {
                case 1:
                    LbValor.Text = string.Format("{0:C}", 1200.00);
                    break;

                case 2:
                    LbValor.Text = string.Format("{0:C}", 500);
                    break;

                case 3:
                    LbValor.Text = string.Format("{0:C}", 4000);
                    break;

                case 4:
                    LbValor.Text = string.Format("{0:C}", 200);
                    break;
                case 5:
                    LbValor.Text = string.Format("{0:C}", 10000);
                    break;

            }
        }

        private void CmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbLocal.SelectedIndex)
            {
                case 1:
                    LbFrete.Text = string.Format("{0:C}", 10);
                    break;

                case 2:
                    LbFrete.Text = string.Format("{0:C}", 50);
                    break;

                case 3:
                    LbFrete.Text = string.Format("{0:C}", 40);
                    break;

                case 4:
                    LbFrete.Text = string.Format("{0:C}", 60);
                    break;
                case 5:
                    LbFrete.Text = string.Format("{0:C}", 20);
                    break;
                case 6:
                    LbFrete.Text = string.Format("{0:C}", 70);
                    break;
                case 7:
                    LbFrete.Text = string.Format("{0:C}", 15);
                    break;

            }
        }
    }
}
