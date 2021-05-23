using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    public partial class Form1 : Form
    {

        public const int RED = 1;
        public const int YELLOW = 2;
        public const int GREEN = 3;
        public const string REDTEXT = "15";
        public const string YELLOWTEXT = "4";
        public const string GREENTEXT = "10";
       

        int status;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(@"C:\Users\alepq\source\repos\ferramentas_visuais\ex3\semaforo\Images\semaforo.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Load(@"C:\Users\alepq\source\repos\ferramentas_visuais\ex3\semaforo\Images\pedestre.png");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "10";
            double t;
            t = double.Parse(textBox1.Text);
            t = t - 1;
            textBox1.Text = t.ToString();

            if (t==0 && status==RED)
            {
                pictureBox1.Load(@".\Images\yellow.png");
                status = YELLOW;
                textBox1.Text = YELLOWTEXT;
            }
            else if (t==0 && status==YELLOW)
            {
                pictureBox1.Load(@".\Images\green.png");
                status = GREEN;
                textBox1.Text = GREENTEXT;
            }
            else if (t==0 && status==GREEN)
            {
                pictureBox1.Load(@".\Images\red.png");
                status = RED;
                textBox1.Text = REDTEXT;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "10";
            double t;
            t = double.Parse(textBox1.Text);
            if (status == RED && t == double.Parse(REDTEXT))
            {
                pictureBox2.Load(@".\Images\pedestreGreen.png");
            }
            else if (status == YELLOW && t == double.Parse(YELLOWTEXT))
            {
                pictureBox2.Load(@".\Images\pedestreRed.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            string x = Application.ExecutablePath;
            MessageBox.Show(x);

            pictureBox1.Load(@".\Images\red.png");
            pictureBox2.Load(@".\Images\pedestreGreen.png");
        }
    }
}
