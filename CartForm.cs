using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yar_bfng
{
    public partial class CartForm : Form
    {
        public static List<Product> products = new List<Product>();

        public CartForm()
        {
            InitializeComponent();
            Text = "Корзина";
            pictureBoxCart.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBox1.Image;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {

        }
    }
}
