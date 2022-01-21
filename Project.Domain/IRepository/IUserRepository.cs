using BRW.Domain.Entities;

namespace BRW.Domain.IRepository;

public interface IUserRepository
{
    public Task<List<User>> GetAllUsers();

    public Task<User?> GetUserByGuid(Guid guid);
    public Task<bool> UserEmailExists(string email);

    public Task<User> CreateUser(User user);
}