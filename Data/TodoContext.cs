using Microsoft.EntityFrameworkCore;
using TodoList.Models; // 確保有引用 Models 命名空間

namespace TodoList.Data
{
  public class TodoContext : DbContext
  {
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    { }

    public DbSet<Todo> Todos { get; set; }
  }
}
