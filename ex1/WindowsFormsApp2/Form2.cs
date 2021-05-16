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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string texto;
            string[] campo, linhas;
            int i = 0;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    texto = File.ReadAllText(abrir.FileName);
                    dados.Rows.Clear();
                    linhas = texto.Split('\r');

                    object[] rows = new object[linhas.Length];

                    foreach (string linha in linhas)
                    {
                        campo = linha.Split(',');
                        rows[i++] = campo;
                    }

                    foreach (string[] vetorLinhas in rows)
                    {
                        dados.Rows.Add(vetorLinhas);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
