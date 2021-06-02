using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoApp
{
    public partial class Orders : Form
    {

        private static readonly string baseURL = "http://localhost:8082/api/v1/orders";
        public Orders()
        {
            InitializeComponent();
        }

        public static async Task<string> GetAll()
        {

            Order order = new Order();
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "/all"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var ordersData = await Orders.GetAll();

            DataTable dataGrid = (DataTable)JsonConvert.DeserializeObject(ordersData, (typeof(DataTable)));
            dataGridView1.DataSource = dataGrid;
        }

        public void obtemPedidos(string data, string descricao, double preco)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirPedido ir = new InserirPedido();
            ir.Show();
        }
    }
}
