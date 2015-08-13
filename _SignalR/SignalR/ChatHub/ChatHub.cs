using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.ChatHub
{
   public class ChatHub : Hub
   {
      public void Wyslij(string nazwa, string wiadomosc)
      {
         // Call the broadcastMessage method to update clients.
         Clients.All.nadajWiadomosc(nazwa, wiadomosc);
      }

      //public void Hello()
      //{
      //   Clients.All.hello();
      //}
   }
}