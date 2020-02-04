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

            pictureBox1.Load("../../Pictures/bg.jpg");
            BackgroundImage = pictureBox1.Image;

            if (text == "Процессоры")
            {
                pictureBox2.Load("../../Pictures/ryzen5_2600.jpg");
                textBox2.Text = "AMD Ryzen 5 2600x";
                pictureBox3.Load("../../Pictures/ryzen7_3700x.jpg");
                textBox3.Text = "AMD Ryzen 7 3700x";
                pictureBox4.Load("../../Pictures/ryzen9.jpg");
                textBox4.Text = "AMD Ryzen 9";
                pictureBox5.Load("../../Pictures/intel_corei9.jpg");
                textBox5.Text = "Intel Core I9";
                pictureBox6.Load("../../Pictures/intel i9_9940x.jpg");
                textBox6.Text = "Технические характеристики" +
                    Environment.NewLine + "Количество потоков: 28" +
                    "";
/*Частота процессора(МГц)""


3300
Пропускная способность шины(GT / s)
8
Тепловыделение(Вт)
165
Максимальная температура °C
88
Разрядность ЦАП(бит)
64
Технологический процесс(nm)
14
Спецификация памяти
Тип оперативной памяти

DDR4
Макс.объем оперативной памяти(Гб)
128
Поддержка памяти ECC
N
Количество каналов памяти
4
Поддержка частот памяти(МГц)
2666
Спецификация PCI Express
Версия PCI Express
3.0
Количество каналов PCI Express
44
Встроенная графика
Встроенное графическое ядро
N";*/
            }
            if (text == "Видеокарты")
            {
                pictureBox2.Load("../../Pictures/bg.jpg");
                textBox2.Text = "Все death";
            }
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}
