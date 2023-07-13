using Microsoft.EntityFrameworkCore;
using TodoList2.Dto.UserDtos;
using TodoList2.Models;

namespace TodoList2.Data.UserRepo
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly TodoContext _context;
        public SqlUserRepository(TodoContext context) {  _context = context; }

        public Task BlockUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
          
        }

        public Task<User> GetUserByName(string username)
        {
            throw new NotImplementedException();
        }

        public Task Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task Register(User user)
        {
            if(user == null) 
                throw new ArgumentNullException("user");

               await _context.Users.AddAsync(user);
               await _context.SaveChangesAsync();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
