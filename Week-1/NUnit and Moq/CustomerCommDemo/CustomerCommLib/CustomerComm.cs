namespace CustomerCommLib
{
    /// <summary>
    /// Handles customer communication after a transaction. Depends on
    /// IMailSender via constructor injection so the dependency can be
    /// swapped out (e.g. mocked) for testing.
    /// </summary>
    public class CustomerComm
    {
        private readonly IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("cust123@abc.com", "Some Message");
            return true;
        }
    }
}
