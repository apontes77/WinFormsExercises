using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public string nomeArquivo;
        public Form1()
        {
            this.nomeArquivo = "";
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFilePath = @"C:\Users\alepq\source\repos\ferramentas_visuais\ex1\WindowsFormsApp2\contato.csv";
            string strSeparator = ",";
            StringBuilder sbOutput = new StringBuilder();

            string[] dadosFormulario = new string[]
            {
              textBox1.Text,
                textBox2.Text,
                  textBox3.Text,
                  textBox4.Text,
                    textBox5.Text,
                     textBox6.Text,
                      textBox7.Text
            };


            for (int i = 0; i < dadosFormulario.Length; i++)
            {

                sbOutput.Append(dadosFormulario[i]+",");
              
               
            }
            sbOutput.AppendLine("\n");
            try
            {
                //File.WriteAllText(strFilePath, sbOutput.ToString());
                File.AppendAllText(strFilePath, sbOutput.ToString());
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
