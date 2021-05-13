using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gravaDadosEmArquivoCSV(object sender, EventArgs e)
        {
            OpenFileDialog abreArquivo = new OpenFileDialog();

            string nome = textBox1.Text.ToString();
            string telefone = textBox2.Text.ToString();
            string email = textBox3.Text.ToString();
            string endereco = textBox4.Text.ToString();
            string cidade = textBox5.Text.ToString();
            string estado = textBox6.Text.ToString();
            string empresa = textBox6.Text.ToString();


        }
    }
}
