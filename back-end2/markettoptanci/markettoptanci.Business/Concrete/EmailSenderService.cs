using markettoptanci.Business.Abstract;
using markettoptanci.Entities.Modals;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;

namespace markettoptanci.Business.Concrete
{
    public class EmailSenderService : IEmailSender
    {
        private readonly SmtpSettings _smtpSettings;

        public EmailSenderService(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }
        public async Task<string> SendEmailAsync(string recipiantEmail, string recipientFullName, string content)
        {
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse(_smtpSettings.SenderEmail));
            message.To.Add(MailboxAddress.Parse(recipiantEmail));
            message.Subject = "Sipariş Oluşturuldu!";
            message.Body = new TextPart("plain")
            {
                Text = "Sayın " + recipientFullName + ",\n" + content
            };

            var client = new SmtpClient();

            try
            {
                await client.ConnectAsync(_smtpSettings.Server, _smtpSettings.Port, true);
                await client.AuthenticateAsync(new NetworkCredential(_smtpSettings.SenderEmail, _smtpSettings.Password));
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
                return "Email Sent Succesfully";
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
