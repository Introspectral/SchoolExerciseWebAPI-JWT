using Biluthyrning.Data;
using Biluthyrning.Interface;
using Microsoft.EntityFrameworkCore;

namespace Biluthyrning.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private HttpClient client;


        public UserRepository(HttpClient client)
        {
            this.client = client;
        }

        public async Task<int> CreateUser(User user)
        {
            int id = user.UserId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/Users", id);
            return id;
        }

        public async Task DeleteUser(User user)
        {

            int id = user.UserId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/Users", id);
        }

        public async Task<List<User>> GetAllUsers()
        {

            return await client.GetFromJsonAsync<List<User>>("/api/Users");
        }

        public async Task<User> GetById(int userId)
        {

            return await client.GetFromJsonAsync<User>($"/api/Users/{userId}");
        }

        public async Task UpdateUser(User user)
        {

            int id = user.UserId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/User", id);
        }
    }
}
