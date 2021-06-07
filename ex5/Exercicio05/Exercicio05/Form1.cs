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

namespace Exercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			var filePath = string.Empty;
			var fileContent = string.Empty;

			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = openFileDialog.FileName;

				var fileStream = openFileDialog.OpenFile();

				using (StreamReader reader = new StreamReader(fileStream))
				{
					fileContent = reader.ReadToEnd();
				}
			}

			PopularComponentes(fileContent);
		}

        private void PopularComponentes(string fileContent) 
        {
			string[] vs = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			for (var i = 0; i < vs.Length; i++)
            {
                chart1.Series["Infectados"].Points.AddXY(vs[i].Split('-')[0], vs[i].Split('-')[1]);
			}

			chart1.Series["Infectados"].Sort(0, "Y");
		}
    }
}
