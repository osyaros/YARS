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
        public static int TotalCount = 0;
        public static int TotalPrice = 0;
        public static Dictionary<Product, int> products = new Dictionary<Product, int>();

        public static void calculateCart()
        {
            TotalCount = 0;
            TotalPrice = 0;
            foreach (KeyValuePair<Product, int> kuplenproduct in CartForm.products)
            {
                TotalCount = TotalCount + kuplenproduct.Value;
                TotalPrice = TotalPrice + kuplenproduct.Value * kuplenproduct.Key.price;
            }
        }
        public CartForm()
        {
            InitializeComponent();
            Text = "Корзина";
            Redraw();
        }
        void Redraw()
        {


            pictureBoxCart.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBoxCart.Image;
            Controls.Clear();
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);

            int x = 0;
            int y = 100;
            foreach (KeyValuePair<Product, int> kuplenproduct in CartForm.products)
            {
                Product product = kuplenproduct.Key;

                PictureBox pb = new PictureBox();
                pb.Size = new Size(120, 120);
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
                textBox.Location = new Point(x + 120, y + 30);
                Controls.Add(textBox);

                Label label = new Label();
                label.Size = new Size(100, 30);
                label.Text = (product.price * kuplenproduct.Value).ToString() + "руб";
                label.Location = new Point(x + 430, y + 30);
                Controls.Add(label);

                Label pricetovar = new Label();
                pricetovar.Size = label.Size;
                pricetovar.Text = product.price.ToString();
                pricetovar.Visible = false;
                pricetovar.Location = new Point(x + 120, y + 70);
                Controls.Add(pricetovar);



                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new Point(x + 270, y + 30);
                numericUpDown.Size = new Size(60, 40);
                numericUpDown.Value = kuplenproduct.Value;
                numericUpDown.ValueChanged += new EventHandler(numericUpDown_ValueChanged);
                Controls.Add(numericUpDown);

                Button but = new Button();
                but.Location = new Point(x + 550, y + 30);
                but.Size = new Size(60, 20);
                but.Text = "Удалить";
                but.Click += new EventHandler(deleteproduct);
                Controls.Add(but);



                y = y + 150;


            }
           


            Label l = new Label();
            l.Text = "Промокод";
            l.Location = new Point(670, 110);
            Controls.Add(l);

            TextBox tx = new TextBox();
            tx.Location = new Point(670, 140);
            tx.Size = new Size(100, 30);
            Controls.Add(tx);


            Button bb = new Button();
            bb.Location = new Point(670, 170);
            bb.Size = new Size(100, 30);
            bb.Text = "Проверить promo";
            bb.Click += new EventHandler(promocheck);
            Controls.Add(bb);


        }
        /// <summary>
        /// удаление товар
        /// </summary>

        void deleteproduct(object sender, EventArgs e)
        {
            int i = 0;
            Button nud = (Button)sender;
            Dictionary<Product, int> products1 = new Dictionary<Product, int>();
            foreach (KeyValuePair<Product, int> pro in CartForm.products)
            {
                if (nud.Location == new Point(550, 150 * i + 130))
                {

                }
                else
                {
                    products1[pro.Key] = pro.Value;
                }
                i++;
            }
            products = products1;
            Redraw();
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;

            for (int i = 0; i < CartForm.products.Count; i++)
            {
                if (nud.Location == new Point(270, 150 * i + 130))
                {
                    int price = 0;
                    Image image = null;
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is PictureBox &&
                            ctrl.Location == new Point(0, 150 * i + 100))
                        {
                            image = ((PictureBox)ctrl).Image;
                        }
                    }
                    foreach (Product prod in CategoryForm.product_list)
                    {
                        if (prod.pb.Image == image)
                        {
                            CartForm.products[prod] = Convert.ToInt32(nud.Value);
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(120, 150 * i + 170))
                        {
                            price = Convert.ToInt32(ctrl.Text);
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label &&
                            ctrl.Location == new Point(430, 150 * i + 130))
                        {
                            ctrl.Text = (price * nud.Value).ToString() + "руб";
                        }
                    }

                    //int x = nud.Value * CartForm.products.Keys[i].price;
                }

            }

            calculateCart();
            label1.Text = TotalPrice.ToString();
            


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

        private void button2_Click(object sender, EventArgs e)
        {
            Sendmail f = new Sendmail();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void proverkaclick(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        bool promos = false;
        private void promocheck(object sender, EventArgs e)
        {   
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox &&
                      ctrl.Location == new Point(670, 140))
                {
                    if (ctrl.Text == "CONFIG777" && promos == false)
                    {
                        MessageBox.Show("Промокод активирован");
                       
                       
                        TotalPrice = TotalPrice*80/100;
                        promos = true;
                    }
                    else
                    {
                        MessageBox.Show("Этого промокод недействителен");
                    }

                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string processorEst = "";
            string matplatEst = "";

            foreach (KeyValuePair<Product, int> kuplenproduct in CartForm.products)
            {

                if (kuplenproduct.Key.type == "Процессоры") processorEst = kuplenproduct.Key.socket;
                if (kuplenproduct.Key.type == "Материнские платы") matplatEst = kuplenproduct.Key.socket;
            }


            if (processorEst != matplatEst)
                MessageBox.Show("Комплектующие не совместимы(процессор и материнская плата)");
            else
                MessageBox.Show("Всё совместимо");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

