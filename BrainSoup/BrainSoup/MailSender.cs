using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
namespace BrainSoup
{
    class MailSender
    {

        public static string mailUser = "*****************************";
        public static string mailPasword = ""*****************************";";
        public static string  GetValidEmail(string email)
        {
            try
            {
               
                var mail = new MailAddress(email);
                bool isValidEmail = mail.Host.Contains(".");
                if (!isValidEmail)
                {
                    return "invalid";
                }
                else
                {
                    return "valid";
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                return "invalid";
            }
        }
        public static string GetLocalIPAddress()
        {
            try
            {
                var webClient = new WebClient();

                string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
                dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;

                webClient.Dispose();
                return dnsString;
            }
            catch
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("Hata Ip Adresi Bulunamadı!");
            }
        }
        public static void Send(string to, string subject, string message)
        {
            try
            {
                string email = MailSender.mailUser;
                string sifre = MailSender.mailPasword;
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                sc.Credentials = new NetworkCredential(email, sifre);

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(email, "BrainSoup Şifre Yenileme İsteği");

                mail.To.Add(to);

                mail.Subject = subject; mail.IsBodyHtml = true; mail.Body = message + "\n \n +Ip Adresi:" + GetLocalIPAddress();
               


                sc.Send(mail);
               // ErrorPage.ShowErr("Mail Başarıyla Gönderildi.");

            }
            catch
            {
               // ErrorPage.ShowErr("Mail Gönderilemedi.");
            }
        }

    }
}
