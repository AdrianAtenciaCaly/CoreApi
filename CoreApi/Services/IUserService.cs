using CoreApi.Models;
using System.Threading.Tasks;

namespace CoreApi.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}
