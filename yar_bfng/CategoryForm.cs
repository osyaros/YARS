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
    public struct Product
    {
        public string name;
        public string mark;
        public int price;
        public string type;
        public PictureBox pb;
        public TextBox textbox;

        public Product(string name_, string mark_, int price_, string type_)
        {
            name = name_;
            mark = mark_;
            price = price_;
            type = type_;
            pb = new PictureBox();
            textbox = new TextBox();
        }
    }




    public partial class CategoryForm : Form
    {
        Product[] produc = new Product[26];
        public static List<Product> cart = new List<Product>(); 

        void drawPicture(TextBox textBox, PictureBox pictureBox)
        {
            if (textBox.Text != "")
            {
                pictureBox.Load("../../Pictures/" + textBox.Text + ".jpg");
                pictureBox.Tag = textBox.Text;
            }
            else
            {
                textBox.Visible = false;
                pictureBox.Visible = false;
            }
        }

        public static Product[] product_list = new Product[26];
        public CategoryForm(string text)     
        {
            InitializeComponent();
            Text = text;
            pictureBox1.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBox1.Image;

            product_list[0] = new Product("AMD Ryzen 5 2600x", "AMD", 12000, "Процессоры");
            product_list[1] = new Product("AMD Ryzen 7 3700x", "AMD", 25000, "Процессоры");
            product_list[2] = new Product("AMD Ryzen 9", "AMD", 50000, "Процессоры");
            product_list[3] = new Product("Intel Core I9-9900KS", "Intel", 60000, "Процессоры");
            product_list[4] = new Product("Intel i9_9940x", "Intel", 100000, "Процессоры");
            product_list[5] = new Product("MSI Nvidia Geforce GTX 1660", "MSI", 17000, "Видеокарты");
            product_list[6] = new Product("ASUS Geforce GTX 1080 Ti", "ASUS", 100000, "Видеокарты");
            product_list[7] = new Product("MSI Nvidia Geforce RTX 2060", "MSI", 100000, "Видеокарты");
            product_list[8] = new Product("GIGABYTE nVidia GeForce RTX 2070", "GIGABYTE", 39000, "Видеокарты");
            product_list[9] = new Product("GIGABYTE Nvidia GeForce RTX 2080", "GIGABYTE", 60000, "Видеокарты");
            product_list[10] = new Product("AEROCOOL KCAS PLUS 600Вт", "AEROCOOL", 3300, "Блоки питания");
            product_list[11] = new Product("THERMALTAKE Smart BX1 RGB, 750Вт", "THERMALTAKE", 6000, "Блоки питания");
            product_list[12] = new Product("be quite! DARK POWER PRO 11 850W", "be quite!", 3900, "Блоки питания");
            product_list[13] = new Product("AEROCOOL Strike-X 1100Вт", "AEROCOOL", 10000, "Блоки питания");
            product_list[14] = new Product("be quiet! System Power 9 500W", "TITAN", 6900, "Блоки питания");
            product_list[15] = new Product("TITAN TTC NK35TZ", "Intel", 5000, "Системы охолождения");
            product_list[16] = new Product("DEEPCOOL Watercooler GAMMAXX L240T WHITE", "DEEPCOOL", 4500, "Системы охолождения");
            product_list[17] = new Product("DEEPCOOL Watercooler CASTLE 240 V2", "DEEPCOOL", 7000, "Системы охолождения");
            product_list[18] = new Product("MSI B450 GAMING PRO CARBON AC", "MSI", 6000, "Материнские платы");
            product_list[19] = new Product("GIGABYTE B450 AORUS ELITE", "GIGABYTE", 8000, "Материнские платы");
            product_list[20] = new Product("GIGABYTE B365 M AORUS ELITE", "GIGABYTE", 7000, "Материнские платы");
            product_list[21] = new Product("MSI MPG Z390 GAMING PRO CARBON", "GIGABYTE", 140000, "Материнские платы");
            product_list[22] = new Product("ASUS ROG STRIX X299-E GAMING", "ASUS", 21000, "Материнские платы");
            product_list[23] = new Product("SAMSUNG 860 EVO MZ-76E500BW 500Гб", "SAMSUNG", 5560, "SSD накопители");
            product_list[24] = new Product("KINGSTON A400 SA400S37 480Гб", "KINGSTON", 7800, "SSD накопители");
            product_list[25] = new Product("SAMSUNG 970 EVO Plus MZ-V7S500BW 500Гб", "SAMSUNG", 8950, "SSD накопители");

            //CartForm.products.Clear();
            //CartForm.products.Add(product_list[12]);



            int x = 0;
            int y = 0;
            for (int i = 0; i < product_list.Length; i++)
            {
                product_list[i].pb.Size = new Size(150, 150);
                product_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                product_list[i].pb.Load("../../Pictures/" + product_list[i].name + ".jpg");
                product_list[i].pb.Click += new EventHandler(pictureBox2_Click);
                product_list[i].pb.Tag = product_list[i].name;
                product_list[i].pb.Visible = true;
                
                product_list[i].textbox.Size = new Size(150, 40);
                product_list[i].textbox.ReadOnly = true;
                product_list[i].textbox.Enabled = false;
                product_list[i].textbox.Multiline = true;
                product_list[i].textbox.Text = product_list[i].type + " " + product_list[i].name;

                product_list[i].pb.Location = new Point(x, y);
                product_list[i].textbox.Location = new Point(x, y + 170);
                x = x + 200;

                if (x > Width - 200)
                {
                    y = y + 250;
                    x = 0;
                }

                panel2.Controls.Add(product_list[i].pb);
                panel2.Controls.Add(product_list[i].textbox);
            }


            button1.Visible = false;

            if (text == "Системы охолождения")
            {
                button1.Visible = true;
                button1.Tag = "http://hyperpc.ru";
            }

            filter_Click(null, null);
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public static void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < product_list.Length; i++)
            {
                if (((PictureBox)sender).Image == product_list[i].pb.Image)
                {
                    ProductForm f = new ProductForm(product_list[i]);
                    f.Show();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag != null)
            {
                System.Diagnostics.Process.Start(button1.Tag.ToString());
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < product_list.Length; i++)
            {
                product_list[i].pb.Visible = true;
                product_list[i].textbox.Visible = true;

                //if (priceTextBox.Text != "" && !product_list[i].name.Contains(priceTextBox.Text))

                if (priceTextBox.Text != "" &&
                    product_list[i].price >= Convert.ToInt32(priceTextBox.Text))
                {
                    product_list[i].pb.Visible = false;
                    product_list[i].textbox.Visible = false;
                }
                else if (typeComboBox.Text != "" &&
                    product_list[i].type != typeComboBox.Text)
                {
                    product_list[i].pb.Visible = false;
                    product_list[i].textbox.Visible = false;
                }
                else if (searchBox.Text != "" &&
                        !product_list[i].name.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    product_list[i].pb.Visible = false;
                    product_list[i].textbox.Visible = false;
                }

                if (product_list[i].pb.Visible)
                {
                    product_list[i].pb.Location = new Point(x, y);
                    product_list[i].textbox.Location = new Point(x, y + 170);
                    x = x + 200;

                    if (x > Width - 200)
                    {
                        y = y + 250;
                        x = 0;
                    }
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_Click(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Height > 20)
            {
                panel1.Height = 20;
                panel2.Location = new Point(panel1.Location.X, 130);
            }
            else
            {
                panel1.Height = 80;
                panel2.Location = new Point(panel1.Location.X, 210);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CartForm f = new CartForm();
            f.Show();
        }
    }
}
