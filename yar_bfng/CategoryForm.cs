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
    public partial class CategoryForm : Form
    {
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

        public CategoryForm(string text)
        {
            InitializeComponent();
            Text = text;
            button1.Visible = false;
            pictureBox1.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBox1.Image;
            TextBox[] tb = new TextBox[20];

            tb[0] = textBox2;
            tb[1] = textBox3;
            tb[2] = textBox4;
            tb[3] = textBox5;
            tb[4] = textBox6;

            textBox2.Text = "";

            if (text == "Процессоры")
            {
                textBox2.Text = "AMD Ryzen 5 2600x";
                textBox3.Text = "AMD Ryzen 7 3700x";
                textBox4.Text = "AMD Ryzen 9";
                textBox5.Text = "Intel Core I9-9900KS";
                textBox6.Text = "Intel i9_9940x";
            }
            if (text == "Видеокарты")
            {
                textBox2.Text = "MSI Nvidia Geforce GTX 1660";
                textBox3.Text = "ASUS Geforce GTX 1080 Ti";
                textBox4.Text = "MSI Nvidia Geforce RTX 2060";
                textBox5.Text = "GIGABYTE nVidia GeForce RTX 2070";
                textBox6.Text = "GIGABYTE Nvidia GeForce RTX 2080";
            }
            if (text == "Блоки питания")
            {
                textBox2.Text = "AEROCOOL KCAS PLUS 600Вт";
                textBox3.Text = "THERMALTAKE Smart BX1 RGB, 750Вт";
                textBox4.Text = "be quite DARK POWER PRO 11 850W";
               /* for (int i = 3; i < 5; i++)
                {
                    tb[i].Visible = false;
                }*/
                textBox5.Text = "AEROCOOL Strike-X 1100Вт";
                textBox6.Text = "ACCORD GOLD ACC-1500Вт";
            }

            if (text == "Системы охолождения")
            {
                button1.Visible = true;
                textBox2.Text = "TITAN TTC NK35TZ";
                textBox3.Text = "DEEPCOOL Watercooler GAMMAXX L240T WHITE";
                textBox4.Text = "DEEPCOOL Watercooler CASTLE 240 V2";
                button1.Tag = "http://hyperpc.ru";


            }

            drawPicture(textBox2, pictureBox2);
            drawPicture(textBox3, pictureBox3); 
            drawPicture(textBox4, pictureBox4);
            drawPicture(textBox5, pictureBox5);
            drawPicture(textBox6, pictureBox6);   
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ProductForm f = new ProductForm(pb.Tag.ToString());
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag != null)
            {
                System.Diagnostics.Process.Start(button1.Tag.ToString());
            }
        }
    }
}
