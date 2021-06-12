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
            int X = 12;
            int Y = 12;

            List<Order> lista = result.ToObject<List<Order>>();
            foreach(var item in lista) 
            {
                Panel panel = new Panel();
                panel.Parent = this;
                panel.Width = 320;
                panel.Height = 172;
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Visible = true;
                panel.Location = new Point(X, Y);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Parent = panel;
                pictureBox.Width = 111;
                pictureBox.Height = 103;
                pictureBox.Location = new Point(17, 16);
                pictureBox.Visible = true;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(item.dishPhoto);
                pictureBox.Show();

                Label labelId = new Label();
                labelId.Parent = panel;
                labelId.Visible = true;
                labelId.Location = new Point(146, 16);
                labelId.Text = "ID:";
                labelId.Width = 21;
                labelId.Show();

                Label labelInfoId = new Label();
                labelInfoId.Parent = panel;
                labelInfoId.Visible = true;
                labelInfoId.Location = new Point(173, 16);
                labelInfoId.Text = item.id.ToString();
                labelInfoId.Show();

                Label labelDate = new Label();
                labelDate.Parent = panel;
                labelDate.Visible = true;
                labelDate.Location = new Point(134, 44);
                labelDate.Text = "Date:";
                labelDate.Width = 33;
                labelDate.Show();

                Label labelInfoDate = new Label();
                labelInfoDate.Parent = panel;
                labelInfoDate.Visible = true;
                labelInfoDate.Width = 100;
                labelInfoDate.Height = 13;
                labelInfoDate.Location = new Point(173, 44);
                labelInfoDate.Text = item.dateOrder.ToString();
                labelInfoDate.Show();

                Label labelPrice = new Label();
                labelPrice.Parent = panel;
                labelPrice.Visible = true;
                labelPrice.Width = 34;
                labelPrice.Height = 13;
                labelPrice.Location = new Point(133, 71);
                labelPrice.Text = "Price:";
                labelPrice.Width = 34;
                labelPrice.Show();

                Label labelInfoPrice = new Label();
                labelInfoPrice.Parent = panel;
                labelInfoPrice.Visible = true;
                labelInfoPrice.Location = new Point(173, 71);
                labelInfoPrice.Text = item.price.ToString();
                labelInfoPrice.Show();

                Label labelDescription = new Label();
                labelDescription.Parent = panel;
                labelDescription.Visible = true;
                labelDescription.Location = new Point(14, 135);
                labelDescription.Text = "Description:";
                labelDescription.Width = 63;
                labelDescription.Show();

                Label labelInfoDescription = new Label();
                labelInfoDescription.Parent = panel;
                labelInfoDescription.Visible = true;
                labelInfoDescription.Location = new Point(83, 135);
                labelInfoDescription.Text = item.description;
                labelInfoDescription.Show();

                panel.Show();

                if (Y + 188 >= this.Height)
                {
                    Y = 12;
                    X = X + 336;
                }
                else
                    Y = Y + 188;
            }
            
            pictureOrder.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void Orders_Shown(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
