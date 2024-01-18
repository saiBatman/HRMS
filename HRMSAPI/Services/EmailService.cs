using HRMSAPI.DTOs;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HRMSAPI.Services
{
    public class EmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<bool> SendEmailAsync(EmailSendDto emailSend)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(emailSend.To);
            mail.From = new MailAddress(_config["Email:From"],
                _config["Email:ApplicationName"], System.Text.Encoding.UTF8);
            mail.Subject = emailSend.Subject;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = emailSend.Body;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(_config["Email:From"], _config["Email:Key"]);
            client.Port = Convert.ToInt32(_config["Email:port"]);
            client.Host = _config["Email:Host"];
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
