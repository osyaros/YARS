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

            pictureBox1.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBox1.Image;


            textBox2.Text = "";

            if (text == "Процессоры")
            {
                textBox2.Text = "AMD Ryzen 5 2600x";
                textBox3.Text = "AMD Ryzen 7 3700x";
                textBox4.Text = "AMD Ryzen 9";
                textBox5.Text = "Intel Core I9";
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
                textBox5.Text = "";
                textBox6.Text = "";
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
    }
}
