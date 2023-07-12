using Microsoft.EntityFrameworkCore;
using TodoList2.Models;

namespace TodoList2.Data
{
    public class TodoContext : DbContext
    {
       public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

       public DbSet<User> Users { get; set; }
       public DbSet<Todo> Todos { get; set; }
    }
}
