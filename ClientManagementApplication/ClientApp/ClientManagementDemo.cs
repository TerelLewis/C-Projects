using ClientManagementApplicationLibrary;
using System;
using System.Collections.Generic;
using static System.Console;

namespace ClientManagementApplication
{
    class ClientManagementDemo
    {
        static void Main(string[] args)
        {
            ClientManagement clientManagement = new ClientManagement();

            bool keepGoing = true;

            while (keepGoing)
            {
                WriteLine();
                WriteLine();
                WriteLine("Welcome to Client Management System!");
                WriteLine();
                WriteLine("Main Menu");
                WriteLine("1. Add a new client");
                WriteLine("2. View current clients");               
                WriteLine("3. Save client list");
                WriteLine("4. Exit");
                WriteLine();
                Write("Enter your choice (1-4): ");
                ConsoleKeyInfo key = ReadKey(true);
                WriteLine();
                WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        AddNewClient(clientManagement);
                        break;
                    case '2':
                        ViewCurrentClients(clientManagement);
                        break;                  
                    case '3':
                        string filePath = FileProcessor.SaveClientData(clientManagement.GetClients());
                        WriteLine($"Client data saved to {filePath}");
                        break;
                    case '4':
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Invalid choice. Please try again.");
                        break;
                }

                WriteLine("Press any key to return to main menu...");
                ReadKey(true);
            }
        }


        static void AddNewClient(ClientManagement clientManagement)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                WriteLine();

                WriteLine("Add a new client");
                Write("Enter name: ");
                string name = ReadLine();

                Write("Enter email: ");
                string email = ReadLine();

                Write("Enter phone number: ");
                string phone = ReadLine();

                Write("Enter status: ");
                string status = ReadLine();

                Write("Enter rating: ");
                int rating = int.Parse(ReadLine());

                Client newClient = new Client
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Status = status,
                    Rating = rating
                };
                WriteLine();

                if (rating < 3)
                {
                    WriteLine("Clients rated below 3 will not be serviced again.");
                    keepGoing = false;
                    return;
                }
                WriteLine();

                clientManagement.AddClient(newClient);

                WriteLine("Client successfully added.");
                WriteLine();
                WriteLine("Press any key to return to main menu or 'q' to add another client...");
                ConsoleKeyInfo key = ReadKey(true);
                WriteLine();
                WriteLine();

                if (key.KeyChar == 'q')
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
               
            }
        }

        static void ViewCurrentClients(ClientManagement clientManagement)
        {
            List<Client> clients = clientManagement.GetClients();

            WriteLine("Current Clients");
            WriteLine("{0,-20} {1,-30} {2,-15} {3,-10} {4,-7}", "Name", "Email", "Phone", "Status", "Rating");

            // Create a new list to hold the inactive clients
            List<Client> inactiveClients = new List<Client>();

            // Iterate through the clients list and add the inactive clients to the new list
            foreach (Client client in clients)
            {
                if (client.Status.ToLower() == "inactive")
                {
                    inactiveClients.Add(client);
                }
                else
                {
                    WriteLine("{0,-20} {1,-30} {2,-15} {3,-10} {4,-7}",
                        client.Name,
                        client.Email,
                        client.Phone,
                        client.Status,
                        client.Rating);
                }
            }

            // Print the inactive clients after the active clients
            WriteLine("\nInactive Clients");
            WriteLine("{0,-20} {1,-30} {2,-15} {3,-10} {4,-7}", "Name", "Email", "Phone", "Status", "Rating");
            foreach (Client client in inactiveClients)
            {
                WriteLine("{0,-20} {1,-30} {2,-15} {3,-10} {4,-7}",
                    client.Name,
                    client.Email,
                    client.Phone,
                    client.Status,
                    client.Rating);
            }

            bool keepGoing = true;

            while (keepGoing)
            {
                WriteLine();
                WriteLine();
                Write("Enter your choice (1-2): ");
                WriteLine();
                WriteLine("1. Select a client to update information");
                WriteLine("2. Return to main menu");
                WriteLine();
                ConsoleKeyInfo key = ReadKey(true);


                switch (key.KeyChar)
                {
                    case '1':
                        // Ask the user to select a client to update
                        Write("Enter the name of the client to update: ");
                        string name = ReadLine();

                        // Find the selected client in the list of clients
                        Client selectedClient = clients.Find(client => client.Name == name);

                        // If the selected client is null, it means the client with that name was not found
                        if (selectedClient == null)
                        {
                            WriteLine($"Client with name '{name}' not found.");
                        }
                        else
                        {
                            // Call the UpdateClientInformation method with the selected client
                            UpdateClientInformation(clientManagement, selectedClient);
                        }

                        break;
                    case '2':
                        keepGoing = false;
                        break;
                    default:
                        WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void UpdateClientInformation(ClientManagement clientManagement, Client client)
        {
            WriteLine();
            WriteLine();
            WriteLine($"Update information for client: {client.Name}");
            WriteLine("1. Update name");
            WriteLine("2. Update email");
            WriteLine("3. Update phone number");
            WriteLine("4. Update status");
            WriteLine("5. Update rating");
            Write("Enter your choice (1-5): ");
            ConsoleKeyInfo key = ReadKey(true);



            switch (key.KeyChar)
            {
                case '1':
                    Write("Enter new name: ");
                    client.Name = ReadLine();
                    break;
                case '2':
                    Write("Enter new email: ");
                    client.Email = ReadLine();
                    break;
                case '3':
                    Write("Enter new phone number: ");
                    client.Phone = ReadLine();
                    break;
                case '4':
                    Write("Enter new status: ");
                    client.Status = ReadLine();
                    break;
                case '5':
                    Write("Enter new rating: ");
                    client.Rating = int.Parse(ReadLine());
                    break;
                default:
                    WriteLine("Invalid choice. Please try again.");
                    break;
            }
            // Check if the client's rating is less than 3
            if (client.Rating < 3)
            {
                WriteLine($"Client {client.Name} has a rating of less than 3.");
                WriteLine("Please follow up with this client.");
            }




        }

    }
}


