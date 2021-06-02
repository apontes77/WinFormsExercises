using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.login = textBox1.Text;
            usuario.senha = textBox2.Text;

            validaDados(usuario.login, usuario.senha);
        }

        public void validaDados(string login, string senha)
        {
           
            if (login.Length<=7 && login!=string.Empty && senha.Length <= 10 && senha!="")
            {
                    Restaurants restaurant = new Restaurants();
                    restaurant.Show();              
            }
            else
            {
                MessageBox.Show("dados incorretos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
