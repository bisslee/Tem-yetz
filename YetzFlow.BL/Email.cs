using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace YetzFlow.Core
{
   public class Email
    {
        public string SendEmail(string emailTo, string novaSenha)
        {
            try
            {
                var mail = new MailMessage();
                
                mail.From = new MailAddress("tester@biss.com.br");
                mail.To.Add(emailTo);
                mail.Subject = "Nova Senha";
                var plainView = AlternateView.CreateAlternateViewFromString($"This is a text message: \n \n sua nova Senha:{novaSenha}", null, "text/plain");
                var htmlView = AlternateView.CreateAlternateViewFromString($"This is a html message: \n \n sua nova Senha:{novaSenha}", null, "text/html");
                mail.AlternateViews.Add(plainView);
                mail.AlternateViews.Add(htmlView);
                using (SmtpClient client = new SmtpClient())
                {
                    client.Credentials = new System.Net.NetworkCredential("tester@biss.com.br", "conga23!"); //credenciais, senha e email
                    client.Host = "mail.biss.com.br";
                    client.Port = 587;

                    client.Send(mail);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
