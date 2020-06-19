using Microsoft.EntityFrameworkCore;

namespace WebAppHub.Models
{
    public class DbContextTodo: DbContext
    {
        public DbContextTodo(DbContextOptions options)
            : base(options) { }
        public DbSet<Todo> Todo { get; set; }
        public DbSet<UserConnected> UserConnected { get; set; }
    }
}
