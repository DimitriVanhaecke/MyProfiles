using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MyProfiles
{
    public class Message
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TextMessage { get; set; }

        public async Task Send()
        {
            try
            {
                var apiKey = "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";
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("dimitrivh@hotmail.com", "Example User");
                var subject = "Contact";
                var to = new EmailAddress("dimitri.vanhaecke@telenet.be", "Example User");
                var plainTextContent = TextMessage;

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, "");
                var response = await client.SendEmailAsync(msg);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}