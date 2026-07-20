namespace CustomerCommLib
{
    /// <summary>
    /// Contract for sending mail. Abstracting this behind an interface allows
    /// consumers (like CustomerComm) to be unit tested without a real SMTP server.
    /// </summary>
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }
}
