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
            string URI = "http://localhost:8082/api/v1/restaurants";
            Restaurant restaurant = new Restaurant();
           
            restaurant.restaurantName = textBox2.Text;
            restaurant.sloganRestaurant = textBox3.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(restaurant);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
                MessageBox.Show(result.ToString());
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
