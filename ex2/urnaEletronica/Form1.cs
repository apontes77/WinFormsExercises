using System;
using System.Windows.Forms;

namespace urnaEletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exibirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contabilizarNovoVotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
