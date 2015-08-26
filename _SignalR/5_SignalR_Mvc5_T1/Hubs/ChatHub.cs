using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace _5_SignalR_Mvc5_T1.Hubs
{
   public class ChatHub : Hub
   {
      public void Wyslij(string nazwa, string wiadomosc)
      {
         Clients.All.dodajNowaWiadomoscDoStrony(nazwa, wiadomosc);
      }
      public void PokazContext()
      {
         string connectionID = "asdsdsddad";//Context.ConnectionId;
         Clients.All.pokazContextNaStronie(connectionID);
      }


   }
}