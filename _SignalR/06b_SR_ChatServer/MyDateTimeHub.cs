using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace _06b_SR_ChatServer
{
   [HubName("PascalCasedMyDateTimeHub")]
   public class MyDateTimeHub : Hub
   {
      [HubMethodName("PascalCasedGetServerDateTime")]
      public async Task<DateTime> GetServerDateTime()
      {
         return await Task.Run<DateTime>(() => DateTime.Now);
      }
   }
}