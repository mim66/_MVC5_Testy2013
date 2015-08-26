using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
   public class ChatHubMy1 : Hub
   {
      public void Wyslij(string nazwa, string wiadomosc)
      {
         Clients.All.rozglosWiadomosc(nazwa, wiadomosc);
      }
      //public void Hello()
      //{
      //   Clients.All.hello();
      //}
   }
}