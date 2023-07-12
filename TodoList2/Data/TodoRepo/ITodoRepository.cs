using TodoList2.Models;

namespace TodoList2.Data.TodoRepo
{
    public interface ITodoRepository
    {
        Task CreateTodo(Todo todo);

        Task UpdateTodo(Todo todo);

        void DeleteTodo(Todo todo);

        Task<Todo> GetTodoById(int id);

        Task<IEnumerable<Todo>> GetAllTodos();

        Task<bool> SaveChangesAsync();


    }
}
