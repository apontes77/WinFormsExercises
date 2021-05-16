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
        List<Candidato> candidatos;
        public Form3()
        {
            InitializeComponent();
             this.candidatos = new List<Candidato>();

            this.candidatos.Add(new Candidato("Joe Biden",
                                                45,
                                                @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\biden.png",
                                                "PSDB"));
            this.candidatos.Add(new Candidato("Boris Johnson",
                                                    13,
                                                    @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\johnson.png", 
                                                    "Partido Conservador"));
            this.candidatos.Add(new Candidato("Xin Jin Ping",
                                                    16,
                                                    @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\xin.png",
                                                    "Partido Comunista Chinês"));
            this.candidatos.Add(new Candidato("Arthur Lira", 
                                                    24,
                                                    @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\lira.png", 
                                                    "Partido Centrão"));
            this.candidatos.Add(new Candidato("Ronaldo Caiado",
                                                    25,
                                                    @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\caiado.png",
                                                    "Democratas"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //verifico quais são os numeros digitados pelo usuario
            //se o que foi digitado bate com os numeros de candidatos dentro da lista
            //entao mostro mensagem contendo os dados do candidato

            string numeroCandidatoDigitado = textBox1.Text;
            foreach (Candidato candidato in candidatos)
            {
                if (int.Parse(numeroCandidatoDigitado) == candidato.numeroCandidato)
                {
                    pictureBox2.ImageLocation = candidato.foto;
                    label1.Text = candidato.nome;
                    label2.Text = candidato.numeroCandidato.ToString();
                    label3.Text = candidato.partido; 

         
                    MessageBox.Show("Voto Registrado!");
                }
                //else
                //{
                //    MessageBox.Show("Candidato Não encontrado!");
                //}

            }
            pictureBox2.ImageLocation = @"C:\Users\alepq\source\repos\ferramentas_visuais\ex2\urnaEletronica\fim.png";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            MessageBox.Show("Sessão Encerrada!");
            Close();
        }
    }
}
