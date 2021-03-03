using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace RealTimePoC.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, string message)
        {
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}