using System.Collections.Generic;
using System.IO;

namespace ClientManagementApplicationLibrary
{
    public class FileProcessor
    {
        public static string SaveClientData(List<Client> clients)
        {
            string fileName = "ClientData.txt";
            string directoryPath = @"C:\clients\";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Client client in clients)
                {
                    sw.WriteLine($"{client.Name},{client.Email},{client.Phone},{client.Status},{client.Rating}");
                }
            }

            return filePath;
        }
    }
}

