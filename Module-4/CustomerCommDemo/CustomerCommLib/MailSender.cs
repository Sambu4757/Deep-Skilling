using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    /// <summary>
    /// Real implementation of IMailSender. This is the class that would talk
    /// to an actual SMTP server in production. It is intentionally NOT used
    /// directly in unit tests, since that would require live network/SMTP access.
    /// </summary>
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            // In a real implementation this would use SmtpClient to send mail, e.g.:
            //
            // using var client = new SmtpClient("smtp.example.com");
            // var mailMessage = new MailMessage("noreply@example.com", toAddress, "Notification", message);
            // client.Send(mailMessage);

            return true;
        }
    }
}
