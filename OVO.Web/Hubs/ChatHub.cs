using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace OVO.Web.Hubs
{
    public class ChatHub : Hub
    {
        private List<string> users = new List<string>();

        public override Task OnConnected()
        {
            var user = Context.Request.User.Identity.Name;

            if (user != null)
            {
                this.users.Add(user);
            } 
            else
            {
                this.users.Add("Anonimous");
            }

            this.Clients.All.joinUser(user, this.users.ToArray());

            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            var user = Context.Request.User.Identity.Name;

            if (user != "Anonimous")
            {
                this.users.Remove(user);
            }
            else
            {
                this.users.Remove("Anonimous");
            }

            this.Clients.All.disconnectUser(user, this.users.ToArray());

            return base.OnDisconnected(stopCalled);
        }
       
        public void SendMessage(string message)
        {
            var user = Context.Request.User.Identity.Name;
            this.Clients.All.addMessage(message, user);
        }
    }
}