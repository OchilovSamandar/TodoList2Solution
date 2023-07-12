using Microsoft.EntityFrameworkCore;
using TodoList2.Models;

namespace TodoList2.Data
{
    public class SqlTodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public SqlTodoRepository(TodoContext context) {  _context = context; }

        public async Task CreateTodo(Todo todo)
        {
            if (todo == null) { 
                throw new ArgumentNullException(nameof(todo)); }

            await _context.Todos.AddAsync(todo);
            
        }

        public  void DeleteTodo(Todo todo)
        {
            if(todo == null) {
                throw new ArgumentNullException();

                 _context.Todos.Remove(todo);
            }
        }

        public async Task<IEnumerable<Todo>> GetAllTodos()
        {
            return  await _context.Todos.ToListAsync();

        }

        public async Task<Todo> GetTodoById(int id)
        {
            return await _context.Todos.FirstOrDefaultAsync(todo => todo.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public Task UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
