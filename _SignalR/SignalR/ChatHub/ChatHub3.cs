using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
   public class ChatHub3 : Hub
   {
      public void Send(string name, string message)
      {
         Clients.All.broadcastMessage(name, message);
      }
      //public void Hello()
      //{
      //   Clients.All.hello();
      //}
   }
}