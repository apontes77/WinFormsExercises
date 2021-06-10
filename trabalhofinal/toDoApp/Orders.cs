using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace toDoApp
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Orders_Load(object sender, EventArgs e)
        {
            var orderData = await OrderAPI.GetAll();
            var result = JArray.Parse(orderData);
            List<Order> lista = result.ToObject<List<Order>>();

            lblDescription.Text = lista[0].description;
            lblId.Text = lista[0].id.ToString();
            lblDate.Text = lista[0].dateOrder.ToString();
            lblPrice.Text = lista[0].price.ToString();
            pictureOrder.Load(lista[0].dishPhoto);
            
            pictureOrder.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void Orders_Shown(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
