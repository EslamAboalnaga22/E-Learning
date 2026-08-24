using ELearning.Core.Configuration;
using MimeKit;
using MailKit.Net.Smtp;

namespace ELearning.Infrastructure.Repositories
{
    public class MailRepository(IOptions<EmailConfiguration> options) : IMailRepository
    {
        private readonly EmailConfiguration emailConfiguration = options.Value;
        public async Task<bool> SendMailAsync(string email, string token, string weblink)
        {
            MimeMessage emailMassage = new();

            MailboxAddress emailForm = new(emailConfiguration.Name, emailConfiguration.EmailId);
            emailMassage.From.Add(emailForm);


            MailboxAddress emailTo = new(email, email);
            emailMassage.To.Add(emailTo);

            emailMassage.Subject = "Reset Password Token";

            var resetLink = $"{weblink}?email={Uri.EscapeDataString(email)}&token={Uri.EscapeDataString(token)}";


            BodyBuilder emailBodyBuilder = new()
            {
                TextBody = $"Reset your password using this link: {resetLink}",
                HtmlBody = $"""
        <html>
        <body>
            <p>Click the button below to reset your password:</p>

            <a href="{resetLink}">
                Reset Password
            </a>
        </body>
        </html>
        """

            };

            emailMassage.Body = emailBodyBuilder.ToMessageBody();

            // SmtpClient Class form Mailkit
            MailKit.Net.Smtp.SmtpClient smtpClient = new();
            smtpClient.Connect(emailConfiguration.Host, emailConfiguration.Port, emailConfiguration.UseSSL);
            smtpClient.Authenticate(emailConfiguration.EmailId, emailConfiguration.Password);
            smtpClient.Send(emailMassage);
            smtpClient.Disconnect(true);
            smtpClient.Dispose();

            return true;
        }
    }
}
