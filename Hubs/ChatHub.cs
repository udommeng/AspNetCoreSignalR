using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToHub(string user, string message) => await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
