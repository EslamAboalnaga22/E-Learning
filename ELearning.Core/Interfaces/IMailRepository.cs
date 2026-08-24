namespace ELearning.Core.Interfaces
{
    public interface IMailRepository
    {
        Task<bool> SendMailAsync(string email, string token , string weblink);
    }
}
