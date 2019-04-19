using System.Threading.Tasks;

namespace CreaStoreNET.Module.Core.Services {
    public interface IEmailSender {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
