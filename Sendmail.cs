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
    public partial class Sendmail : Form
    {
        public Sendmail()
        {
            InitializeComponent();
        }

        private void Sendmail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                MailAddress fromMailAddress = new MailAddress("osyaros08042005@gmail.com", "Osokin Yaroslav");
                MailAddress toAddress = new MailAddress(textBox1.Text, "Kinso");

                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mailMessage.Subject = "Привет";
                    mailMessage.Body = "А вот и список комплектующих" + Environment.NewLine;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = System.IO.File.ReadAllText("Шаблон.txt");
                System.IO.File.WriteAllText("Заказ.xls", "Название,Цена");
                foreach (KeyValuePair<Product, int> kuplenproduct in CartForm.products)
                {
                    Product product = kuplenproduct.Key;
                    System.IO.File.AppendAllText("Заказ.csv",
                        Environment.NewLine +
                        product.name + "," + product.price);                      
                }
                mailMessage.Attachments.Add(new Attachment("Заказ.csv"));

                smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "fuze040380");

                    smtpClient.Send(mailMessage);
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
