using Biluthyrning.Data;

namespace Biluthyrning.Interface
{
    public interface IUserRepository
    {
        public Task<int> CreateUser(User user);
        Task <User> GetById(int userId);
        public Task UpdateUser(User user);
        public Task DeleteUser(User user);
        Task <List<User>> GetAllUsers();
    }
}
