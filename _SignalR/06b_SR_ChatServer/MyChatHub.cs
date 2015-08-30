using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace _06b_SR_ChatServer
{
   public class MyChatHub : Hub
   {
      public async Task BroadcastMessage(string callername, string message) 
      {
         // Case-insensitive when the server RPC the client's methods
         await Clients.All.appendnewmessage(callername, message);
      }
   }
}