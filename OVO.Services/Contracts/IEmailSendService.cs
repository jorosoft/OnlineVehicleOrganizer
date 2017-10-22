using System.Threading.Tasks;

namespace OVO.Services.Contracts
{
    public interface IEmailSendService
    {
        Task SendEmailAsync(string destinationEmail, string message);
    }
}
