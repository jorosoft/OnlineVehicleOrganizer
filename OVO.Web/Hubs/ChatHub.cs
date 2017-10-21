using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace OVO.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            var user = Context.Request.User.Identity.Name;
            Clients.All.addMessage(message, user);
        }
    }
}