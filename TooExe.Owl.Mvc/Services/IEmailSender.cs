using System.Threading.Tasks;

namespace TooExe.Owl.Mvc.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}