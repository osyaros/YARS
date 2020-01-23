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
        public CategoryForm(string text)
        {
            InitializeComponent();
            Text = text;

            if (text == "Процессоры")
            {
                pictureBox1.Load("../../Pictures/bg.jpg");
                BackgroundImage = pictureBox1.Image;
            }
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}
