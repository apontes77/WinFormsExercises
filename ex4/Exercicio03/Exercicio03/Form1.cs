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

namespace Exercicio03
{
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
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

		private void PopularComponentes(String text) 
		{
            double nota = 0.0;
			double notas = 0.0;
			double notaAlta = 0.0;
			double notaBaixa = 11;
			double media = 0.0;
			var i = 0;
			var countBaixaMedia = 0;
			var countAltaMedia = 0;

			string[] vs = text.Split();

			vs = vs.Where(val => val != "").ToArray();

			for (i = 0; i < vs.Length -1; i++) 
			{
				nota = double.Parse(vs[i]);
				notas = notas + nota;

				if (nota > notaAlta)
				{
					notaAlta = nota;
				}
				else if (nota < notaBaixa)
				{
					notaBaixa = nota;
				}

				if (nota >= 6.0)
				{
					countAltaMedia++;
				}
				else
				{
					countBaixaMedia++;
				}
				
		}
			media = notas / i;

			txtQuantidadeNotas.Text = i.ToString();
			txtMedia.Text = media.ToString("0.00");
			txtNotaMaisAlta.Text = notaAlta.ToString("0.00");
			txtNotaMaisBaixa.Text = notaBaixa.ToString("0.00");
			txtAcimaMedia.Text = ((countAltaMedia * 100) / i).ToString("0.00") + "%";
			txtAbaixoMedia.Text = ((countBaixaMedia * 100) / i).ToString("0.00") + "%";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
