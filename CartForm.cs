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
            BackgroundImage = pictureBoxCart.Image;
            int x = 0;
            int y = 100;
            foreach (Product product in CartForm.products)
            {   
                PictureBox pb = new PictureBox();

                pb.Size = new Size(120,120);
                pb.Image = product.pb.Image;
                pb.Location = new Point(x, y);
                pb.SizeMode = product.pb.SizeMode;
                pb.Click += new EventHandler(CategoryForm.pictureBox2_Click);
                pb.Visible = product.pb.Visible;

                Controls.Add(pb);

                TextBox textBox = new TextBox();
                textBox.Size = product.textbox.Size;
                textBox.BackColor = Color.White;
                textBox.ReadOnly = product.textbox.ReadOnly;
                textBox.Enabled = false;
                textBox.Multiline = true;
                textBox.Text = product.textbox.Text;
                textBox.Location = new Point(x + 120, y+30);
                Controls.Add(textBox);

                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Text = product.price.ToString() + "руб";
                label.Location = new Point(x + 330, y +30);
                Controls.Add(label);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(x + 270, y + 30);
                numericUpDown1.Size = new Size(60, 40);
                Controls.Add(numericUpDown1);

                y = y + 150;
               
                //   Controls.Add(product.price);
            }
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
