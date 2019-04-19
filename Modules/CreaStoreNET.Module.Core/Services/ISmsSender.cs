using System.Threading.Tasks;

namespace CreaStoreNET.Module.Core.Services {
    public interface ISmsSender {
        Task SendSmsAsync(string number, string message);
    }
}
