using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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

        int status = RED;


        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load("..\\..\\imagens\\semaforo.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Load("..\\..\\imagens\\pedestre.png");

        } 

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();

            if (status == RED)
            {
                pictureBox1.Load("..\\..\\imagens\\yellow.png");
                pictureBox2.Load("..\\..\\imagens\\pedestreGreen.png");
                status = YELLOW;
                textBox1.Text = YELLOWTEXT;
                
            }
            else if (status == YELLOW)
            {
                pictureBox1.Load("..\\..\\imagens\\green.png");
                pictureBox2.Load("..\\..\\imagens\\pedestreRed.png");

                status = GREEN;
                textBox1.Text = GREENTEXT;
            }
            else if (status == GREEN)
            {
                pictureBox1.Load("..\\..\\imagens\\red.png");
                pictureBox2.Load("..\\..\\imagens\\pedestreGreen.png");

                status = RED;
                textBox1.Text = REDTEXT;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
