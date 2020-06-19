using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebAppHub.Models;

namespace WebAppHub.Hubs
{
    public class TodosHub : Hub
    {

        protected DbContextTodo Db { get; }

        public TodosHub(DbContextTodo db)
        {
            Db = db;
        }

        public async Task GetServerCount()
        {
            var count = await Db.Todo.CountAsync();
            await Clients.All.SendAsync("GetClientCount", count);
        }

        public async Task GetServerUserCount()
        {
            var count = await Db.UserConnected.CountAsync(x => x.Status);
            await Clients.All.SendAsync("GetClientUserCount", count);
        }

        public override Task OnConnectedAsync()
        {
            UserConnected userConnected = UserConnected.Create(Context.ConnectionId, DateTime.Now, true);
            Db.UserConnected.Add(userConnected);
            Db.SaveChanges();
            _ = GetServerUserCount();
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            UserConnected userConnected = Db.UserConnected.Find(Context.ConnectionId);
            if (userConnected == null)
            {
                userConnected = UserConnected.Create(Context.ConnectionId, DateTime.Now, false);
                Db.UserConnected.Add(userConnected);                
            } 
            else
            {
                userConnected.Status = false;                
            }
            Db.SaveChanges();
            _ = GetServerUserCount();
            return base.OnDisconnectedAsync(exception);
        }
    }
}
