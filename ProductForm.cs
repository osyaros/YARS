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
        Product product;
        public ProductForm(Product prod)
        {
            product = prod;
            InitializeComponent();
            productpictureBox.Load("../../Pictures/" + prod.name + ".jpg");
            textBox1.Text = prod.name;
            textBox2.Lines = System.IO.File.ReadAllLines("../../Pictures/" + prod.name + ".txt");
            priceBox.Text = prod.price.ToString() + "руб";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CartForm.products.ContainsKey(product))
            
               CartForm.products[product] = CartForm.products[product] + 1;
            else
               CartForm.products.Add(product, 1);

        }
    } 
}
