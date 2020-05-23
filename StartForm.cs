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
            string[] lines = System.IO.File.ReadAllLines("PRODUCTSLIST.txt");
            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                  CategoryForm.product_list.Add(new Product(parts[0], parts[1], Convert.ToInt32(parts[2]), parts[3], parts[4], parts[5]));
            }

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("");
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entercreators f = new Entercreators();
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnWords.Add("Для создателей", "For creators");
            EnWords.Add("Войти", "Sign in");
            EnWords.Add("Зарегестрироваться", "Sign up");
            EnWords.Add("Фильтр", "Filter");


            RuWords.Add("Для создателей", "Для создателей");
            RuWords.Add("Войти", "Войти");
            RuWords.Add("Зарегестрироваться", "Зарегестрироваться");
            RuWords.Add("Фильтр", "Фильтр");
        }
        public static Dictionary<string, string> EnWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RuWords = new Dictionary<string, string>();
        public static string language = "Ru";
        private void button3_Click(object sender, EventArgs e)
        {
            //RU
           
            language = "Ru";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EN
         
            language = "En";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> words = EnWords;
            if (language == "Ru") words = RuWords;
            button2.Text = words["Для создателей"];
        }
    }
}
