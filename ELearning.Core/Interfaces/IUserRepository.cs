namespace ELearning.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(string UserId);
        Task<ApplicationUser> GetUserByNameAsync(string Username);
        Task<ApplicationUser> GetUserByEmailAsync(string Useremail);
        Task<UserRolesModel> GetUserWithRolesAsync(string UserId);
    }
}
