using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSignalR.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR.Pages
{
    public class SendModel : PageModel
    {
        IHubContext<ChatHub> _hub;
        public SendModel(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }
        public async void OnGet(string user, string message)
        {
            await _hub.Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}