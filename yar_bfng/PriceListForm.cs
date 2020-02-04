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
    public partial class PriceListForm : Form
    {
        void changename(string text)
        {
            Text = text;
        }
        public PriceListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Процессоры");
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Блоки питания");
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Системы охолождения");
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Видеокарты");
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Материнские платы");
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("SSD накопители");
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Жесткие диски");
            f.Show();
        }
    }
}
