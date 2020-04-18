using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yar_bfng
{
    public partial class Creatormode : Form
    {
        string FileName = "";
        public Creatormode()
        {
            Text = "Новый объект";
            InitializeComponent();
        }

        private void Creatormode_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("PRODUCTLIST.txt",
                Environment.NewLine +
                NameTB.Text + "," +
                Price.Text.ToString() + "," +
                categorybox.Text
                );
            System.IO.File.WriteAllText(
                                       "../../Pictures/" + NameTB.Text + ".txt", description.Text);
            if (FileName != "")
            {
                System.IO.File.Copy(FileName,
                                     "../../Pictures/" + NameTB.Text + ".jpg"
                    );
            }
        }
        
       


        private void button2_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
