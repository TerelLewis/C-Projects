using System;
using System.Collections.Generic;

namespace ClientManagementApplicationLibrary
{
    public class ClientManagement
    {
        private List<Client> clients;

        public ClientManagement()
        {
            clients = new List<Client>();

            // Add some hard-coded clients to the list
            clients.Add(new Client { Name = "Jackson Wong", Email = "jackson_w@email.com", Phone = "123-456-7890", Status = "Active", Rating = 4 });
            clients.Add(new Client { Name = "Jane Lemon", Email = "jane_l@email.com", Phone = "987-654-3210", Status = "Inactive", Rating = 3 });
            clients.Add(new Client { Name = "Chad Boor", Email = "chad_b@email.com", Phone = "879-664-0213", Status = "Active", Rating = 4 });
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }

        public void UpdateClient(Client oldClient, Client newClient, Client client)
        {
            int index = clients.IndexOf(oldClient);
            clients[index] = newClient;
        }

        public List<Client> GetClients()
        {
            return clients;
        }
    }
}
