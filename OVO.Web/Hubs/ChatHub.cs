using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace OVO.Web.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            var user = Context.Request.User.Identity.Name;

            if (user != string.Empty)
            {
                ChatUsersHandler.Users.Add(user);
            } 
            else
            {
                ChatUsersHandler.Users.Add("Anonimous");
            }

            this.Clients.All.joinUser(user, ChatUsersHandler.Users.OrderBy(x => x).ToArray());

            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            var user = Context.Request.User.Identity.Name;

            if (user != string.Empty)
            {
                ChatUsersHandler.Users.Remove(user);
            }
            else
            {
                ChatUsersHandler.Users.Remove("Anonimous");
            }

            this.Clients.All.disconnectUser(user);

            return base.OnDisconnected(stopCalled);
        }
       
        public void SendMessage(string message)
        {
            var user = Context.Request.User.Identity.Name;
            this.Clients.All.addMessage(message, user);
        }
    }
}