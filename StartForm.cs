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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("");
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entercreators f = new Entercreators();
            f.Show();
        }
    }
}
