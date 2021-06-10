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
    public partial class Form3 : Form
    {
        public List<Candidato> candidatos;

        public List<Candidato> GetCandidatos()
        {
            return candidatos;
        }

        public void SetCandidatos(List<Candidato> value)
        {
            candidatos = value;
        }

        public Form3()
        {
            InitializeComponent();
             this.SetCandidatos(new List<Candidato>());

            this.GetCandidatos().Add(new Candidato("Joe Biden",
                                                45,
                                                "..\\..\\imagens\\biden.png",
                                                "PSDB",0));
            this.GetCandidatos().Add(new Candidato("Boris Johnson",
                                                    13,
                                                    "..\\..\\imagens\\johnson.png", 
                                                    "Partido Conservador",0));
            this.GetCandidatos().Add(new Candidato("Xin Jin Ping",
                                                    16,
                                                    "..\\..\\imagens\\xin.png",
                                                    "Partido Comunista Chinês",0));
            this.GetCandidatos().Add(new Candidato("Arthur Lira", 
                                                    24,
                                                    "..\\..\\imagens\\lira.png", 
                                                    "Partido Centrão",0));
            this.GetCandidatos().Add(new Candidato("Ronaldo Caiado",
                                                    25,
                                                    "..\\..\\imagens\\caiado.png",
                                                    "Democratas",0));
        }

        public void button3_Click(object sender, EventArgs e)
        {
            //verifico quais são os numeros digitados pelo usuario
            //se o que foi digitado bate com os numeros de candidatos dentro da lista
            //entao mostro mensagem contendo os dados do candidato

            string numeroCandidatoDigitado = textBox1.Text;
            foreach (Candidato candidato in GetCandidatos())
            {
                if (int.Parse(numeroCandidatoDigitado) == candidato.numeroCandidato)
                {
                    pictureBox2.ImageLocation = candidato.foto;
                    label1.Text = candidato.nome;
                    label2.Text = candidato.numeroCandidato.ToString();
                    label3.Text = candidato.partido;
                    candidato.qtdeVotos++;

                    MessageBox.Show("Voto Registrado!");

                } 
            }
            pictureBox2.ImageLocation = "..\\..\\imagens\\fim.png";
            
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
           
        }
        private void button14_Click(object sender, EventArgs e)
        {
            encerraSessaoEAbreEstatisticas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            MessageBox.Show("Insira o número do candidato!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "..\\..\\imagens\\fim.png";

            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void encerraSessaoEAbreEstatisticas()
        {
            MessageBox.Show("Sessão Encerrada!");
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
