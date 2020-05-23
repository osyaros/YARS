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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            CategoryForm.login = textBox1.Text;
            System.IO.File.AppendAllText("Пользователи.txt",
                textBox1.Text + Environment.NewLine +
                textBox2.Text + Environment.NewLine);
            Close();
        }
    }
}
