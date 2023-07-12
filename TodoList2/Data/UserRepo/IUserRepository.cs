using TodoList2.Models;

namespace TodoList2.Data.UserRepo
{
    public interface IUserRepository
    {
        Task Login(string username, string  password);

        Task Register(User user);

         Task<User> GetUserById(User user);

        Task<User> GetUserByName(string username);

        Task<ICollection<User>> GetAllUser();

        Task DeleteUser(User user);

        Task BlockUser(User user);
        Task UpdateUser(User user);


    }
}
