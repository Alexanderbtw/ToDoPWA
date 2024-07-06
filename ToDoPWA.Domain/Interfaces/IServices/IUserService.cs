using ToDoPWA.Domain.Entities;

namespace ToDoPWA.Domain.Interfaces.IServices;

public interface IUserService
{
    Task<List<User>> GetUsers();
    Task<User> GetUser(string id);
    Task CreateUser(User user);
    Task UpdateUser(User user);
    Task DeleteUser(string id);
}