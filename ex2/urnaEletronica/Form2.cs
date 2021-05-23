using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaEletronica
{
    public partial class Form2 : Form
    {
        Form3 dadosAtuaisDeVotacao;
        public Form2(Form3 form3)
        {
            InitializeComponent();
            dadosAtuaisDeVotacao = form3;

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Candidato c in dadosAtuaisDeVotacao.candidatos)
            {
                dataGridView1.Rows.Add(c.nome, c.qtdeVotos);
            }
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Eleicao"].Points.Clear();
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
              if (linha.Cells[1].Value != null)
                    chart1.Series["Eleicao"].Points.AddXY(linha.Cells[0].Value, linha.Cells[1].Value);
            }
            chart1.Series["Eleicao"].IsValueShownAsLabel = true;
        }
    }
}
