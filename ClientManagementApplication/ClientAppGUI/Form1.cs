using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagementApplicationLibrary;

namespace ClientAppGUI
{
    public partial class Form1 : Form
    {
        private List<Client> clients;

        public Form1()
        {
            InitializeComponent();
            clients = new List<Client>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Retrieve the list of clients
            List<Client> clients = ClientManager.GetAllClients();

            // Bind the list to the DataGridView
            dataGridView1.DataSource = clients;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Client newClient = new Client
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                Status = statusTextBox.Text,
                Rating = int.Parse(ratingTextBox.Text)
            };

            clients.Add(newClient);
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            statusTextBox.Text = "";
            ratingTextBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


