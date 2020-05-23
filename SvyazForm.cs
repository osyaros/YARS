using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace yar_bfng
{
    public partial class SvyazForm : Form
    {
        public SvyazForm()
        {
            InitializeComponent();
        }

        private void SvyazForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SvyazForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Проверка ошибок
            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Укажите контактный e-mail или телефон");
                return;
            }
            if (textBox1.Text.Length < 15)
            {
                MessageBox.Show("Опишите проблему");
                return;
            }
            #endregion

            MailAddress fromMailAddress = new MailAddress("osyaros08042005@gmail.com", "Osokin Yaroslav");
            MailAddress toAddress = new MailAddress("osyaros.2005@yandex.ru", "YARS");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Новый отзыв";
                mailMessage.Body = "Тема: " + comboBox1.Text + Environment.NewLine +
                    "От кого: " + textBox2.Text + Environment.NewLine +
                    "Сообщение: " + textBox1.Text;
                if (address1 != "")
                    mailMessage.Attachments.Add(new Attachment(address1));
                if (address2 != "")
                    mailMessage.Attachments.Add(new Attachment(address2));
                
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "fuze040380");

                smtpClient.Send(mailMessage);
            }

        }
        string address1 = "";
        string address2 = "";

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
               DialogResult.OK)
            {
                address1 = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
                DialogResult.OK)
            {
                address2 = openFileDialog1.FileName;
                pictureBox2.Load(openFileDialog1.FileName);
            }
        }
    }
}
