using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace _06_SR_Code_Zhuyun_Dai
{
   public class MyConnection : PersistentConnection
   {
      protected override Task OnConnected(IRequest request, string connectionId)
      {
         string msg = string.Format("Nowy user: {0} właśnie dołączył. (ID: {1})", request.QueryString["name"], connectionId);
         return Connection.Broadcast(msg);
         //return Connection.Send(connectionId, "Welcome!");
      }

      protected override Task OnReceived(IRequest request, string connectionId, string data)
      {
         // Broadcast data to all clients
         string msg = string.Format("{0}: {1}", request.QueryString["name"], data);
         return Connection.Broadcast(msg);
      }
   }
}