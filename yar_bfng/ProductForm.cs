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
    public partial class ProductForm : Form
    {
        public ProductForm(string name)
        {
            InitializeComponent();
            productpictureBox.Load("../../Pictures/" + name + ".jpg");
            textBox1.Text = name;
            textBox2.Lines = System.IO.File.ReadAllLines("../../Pictures/" + name + ".txt");
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
