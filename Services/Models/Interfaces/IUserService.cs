using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IUserService
    {
        public Task<bool> AddUserAsync(User user);
        public Task<bool> AddUsersAsync(params User[] users);
        public Task<List<User>> GetAllUsersAsync();
        public Task<User> GetUserByEmailAsync(string email);
        public Task<User> GetUserByPhoneNumberAsync(string phoneNumber);
        public Task<bool> ValidateCredentialsAsync(string credential, string password);
        public Task<bool> ValidateUserExistenceAsync(string credential);
        public Task<bool> VerifyUserAccountAsync();
        public Task<bool> UpdateUserAsync(User user);
        public Task<bool> RemoveUserAsync(User user);
    }
}
