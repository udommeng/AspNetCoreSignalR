using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSignalR.Hubs;
using AspNetCoreSignalR.model;
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
            // รับค่าเข้ามา 
            var myMessage = new MyMessage
            {
                User = user,
                Message = message
            };

            //-- ส่งไปให้ Client
            await _hub.Clients.All.SendAsync("ReceiveMessage", myMessage);
        }
    }
}