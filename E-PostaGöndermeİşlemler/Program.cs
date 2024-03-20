using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace E_PostaGöndermeİşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailGonder("dersingrkmefe2003@gmail.com", "Email gönder işlemleri", "Merhaba GED");
        }

        static void EmailGonder(string kime , string Konu ,string içerik)
        {
            Encoding encode = Encoding.GetEncoding("Utf8");
            MailAddress to1 = new MailAddress("gorkemefe.dersin@adnbilisim.com.tr","Görkem Efe Dersin",encode);
            MailAddress MailFrom = new MailAddress("dersinserdar@gmail.com", "Serdar Dersin", encode);

            MailMessage Email = new MailMessage();

            Email.To.Add(kime);
            Email.To.Add(to1);
            Email.From = MailFrom;
            /*Email.CC.Add(""); Maili alan kişi bu liste içerisinde tanımlı olan kişileri görebiliri
            Email.Bcc.Add("");  Bu alanda ise eklenenleri göremez*/

            Email.Subject = Konu;
            Email.Body = içerik;

            Email.IsBodyHtml = true;

            

            SmtpClient smtpmail = new SmtpClient("mail.cengizatillia.com", 578);
            smtpmail.Credentials = new System.Net.NetworkCredential("dersinserdar@gmail.com", "45944594efe");
            smtpmail.EnableSsl = false;
            smtpmail.Send(Email);
        }
    }
}
