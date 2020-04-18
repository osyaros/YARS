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
    public partial class Entercreators : Form
    {
        public Entercreators()
        {
            InitializeComponent();
            Text = "Вход";
            Label lb = new Label();
            lb.Size = new Size(100, 30);
            lb.Text = "Логин";
            lb.Location = new Point(300, 100);
            Controls.Add(lb);

            Label lb2 = new Label();
            lb2.Size = new Size(100, 30);
            lb2.Text = "Пароль";
            lb2.Location = new Point(300, 160);
            Controls.Add(lb2);
            //Вводим логин
            TextBox tb = new TextBox();
            tb.Text = "";
            tb.Location = new Point(300, 130);
            tb.Size = new Size(100, 50);
            Controls.Add(tb);
            //Вводим пароль
            TextBox tb2 = new TextBox();
            tb2.Text = "";
            tb2.Location = new Point(300, 190);
            tb2.Size = new Size(100, 50);
            Controls.Add(tb2);

            Button bt = new Button();
            bt.Location = new Point(330, 240);
            bt.Text = "Войти";
            bt.Size = new Size(70, 30); 
            bt.Click += new EventHandler(button2_Click);
            Controls.Add(bt);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in Controls)
            {
                if (ctrl is TextBox &&
                      ctrl.Location == new Point(300, 190))
                {
                    if(ctrl.Text == "no admin" )
                    {
                        Creatormode f = new Creatormode();
                        f.Show();
                        break;
                    }
                        
                }
                    
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
