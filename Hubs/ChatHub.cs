using System.Threading.Tasks;
using AspNetCoreSignalR.model;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToHub(MyMessage myMessage)
        {
            await Clients.All.SendAsync("ReceiveMessage", myMessage);
        }
    }
}