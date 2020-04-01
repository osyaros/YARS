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
        public static Dictionary<Product,int> products = new Dictionary<Product,int>();

        public CartForm()
        {
            InitializeComponent();
            Text = "Корзина";
            pictureBoxCart.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBoxCart.Image;
            int x = 0;
            int y = 100;
            foreach (KeyValuePair<Product,int> kuplenproduct in CartForm.products)
            {
               Product product = kuplenproduct.Key;

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
                label.Text = (product.price * kuplenproduct.Value).ToString() + "руб";
                label.Location = new Point(x + 430, y +30);
                Controls.Add(label);

                Label pricetovar = new Label();
                pricetovar.Size = label.Size;
                pricetovar.Text = "";
                pricetovar.Location = new Point(x + 120, y + 70);
                Controls.Add(pricetovar);


                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new Point(x + 270, y + 30);
                numericUpDown.Size = new Size(60, 40);
                numericUpDown.Value = kuplenproduct.Value;
                numericUpDown.ValueChanged += new EventHandler(numericUpDown_ValueChanged);
                Controls.Add(numericUpDown);

                y = y + 150;
               
              
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;

            for(int i = 0; i < CartForm.products.Count;i++)
            {
                if(nud.Location == new Point(270, 150 * i + 130))
                { 
                    int price = 0;

                   foreach(Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(430, 150 * i + 30))
                        {
                            price = Convert.ToInt32(ctrl.Text);
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(120, 150 * i + 70))
                        {
                            ctrl.Text = (price * nud.Value).ToString() + "реее";
                        }
                    }
                    //int x = nud.Value * CartForm.products.Keys[i].price;
                }
            }



            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBoxCart_Click(object sender, EventArgs e)
        {

        }

        
    }
}
