using System.Threading.Tasks;
using OVO.Services.Models;

namespace OVO.Services.Contracts
{
    public interface IEmailSendService
    {
        Task SendEmailAsync(Mail mail);
    }
}
