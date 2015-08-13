﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
//using SignalR.

namespace SignalR
{
   public class ChatHub2 : Hub
   {
      public void Send(string name, string message)
      {
         // Call the broadcastMessage method to update clients.
         Clients.All.broadcastMessage(name, message);
      }

      //public void Hello()
      //{
      //   Clients.All.hello();
      //}
   }
}