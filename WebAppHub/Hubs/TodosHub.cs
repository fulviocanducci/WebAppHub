using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebAppHub.Models;

namespace WebAppHub.Hubs
{
    public class TodosHub : Hub
    {
        public DbContextTodo Db { get; }
        public TodosHub(DbContextTodo db)
        {
            Db = db;
        }

        public async Task GetServerCount()
        {
            var count = await Db.Todo.CountAsync();
            await Clients.All.SendAsync("GetClientCount", count);
        }
    }
}
