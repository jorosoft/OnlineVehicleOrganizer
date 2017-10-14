namespace OVO.Services.Contracts
{
    public interface IEmailService
    {
        void SendAsync(string toEmail, string emailBody);
    }
}
