using Newtonsoft.Json;
using SpiceRanch.structures;

namespace SpiceRanch.managers
{
    internal class ClientManager
    {
        private List<Client> clients;
        private Client? activeClient;

        public ClientManager()
        {
            this.clients = JsonConvert.DeserializeObject<List<Client>>(Utils.APIRestClientResponse)!;
        }

        public Client? Login(string name, string password)
        {
            this.clients.ForEach((client) =>
            {
                if (client == null) return;
                if (client.name == name && client.password == password)
                {
                    this.activeClient = client;
                }
                this.activeClient = null;
            });
            return this.activeClient;
        }

        public void Logout()
        {

        }

        public Client GetActiveClient()
        {
            return this.activeClient;
        }

        public List<Client> GetClients()
        {
            return this.clients;
        }
    }
}
