using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace toDoApp
{
    public partial class Restaurants : Form
    {
        public Restaurants()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var restaurantsData = await RestaurantsAPI.GetAll();

            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(restaurantsData, (typeof(DataTable)));
            dataGridView1.DataSource = dataTable;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var insertRestaurant = await RestaurantsAPI.PostRestaurant(textBox2.Text, textBox3.Text);

            if (insertRestaurant != null)
            {
                MessageBox.Show("Tudo certo!");
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Algum erro ocorreu no POST!");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }
    }
}
