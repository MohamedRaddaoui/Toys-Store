using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SignUpDemo
{
    class MailHelper
    {
        public static void SendMail(string[] adresses, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                //ajouter les destinataires
                foreach (string adress in adresses)
                {
                    mail.To.Add(adress);
                }

                mail.Subject = subject;
                mail.Body = message;
                //définir l'expéditeur
                mail.From = new MailAddress("monfichier3@gmail.com", "infodegestion");
                //définir les paramètres smtp pour l'envoi
                SmtpClient smtpServer = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("monfichier3@gmail.com", "infodegestion")
                };
                //envoi du mail
                smtpServer.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
