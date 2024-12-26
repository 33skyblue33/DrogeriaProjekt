using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrogeriaProjekt.Services.Models
{
    public class UserService : IUserService
    {
        private readonly IDatabaseService DatabaseService;

        public UserService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            await DatabaseService.DatabaseContext.Users.AddAsync(user);
            var result = await DatabaseService.DatabaseContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> AddUsersAsync(params User[] users)
        {
            await DatabaseService.DatabaseContext.Users.AddRangeAsync(users);
            var result = await DatabaseService.DatabaseContext.SaveChangesAsync();

            return result > 0;
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            return DatabaseService.DatabaseContext.Users.ToListAsync();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            var trimmedEmail = email.Trim();
            return DatabaseService.DatabaseContext.Users.Where(u => u.Email == trimmedEmail).FirstOrDefaultAsync();
        }

        public Task<User> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var trimmedPhoneNumber = phoneNumber.Trim();
            return DatabaseService.DatabaseContext.Users.Where(u => u.PhoneNumber == trimmedPhoneNumber).FirstOrDefaultAsync();
        }

        public Task<bool> RemoveUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCredentialsAsync(string credential, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUserExistenceAsync(string credential)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyUserAccountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
