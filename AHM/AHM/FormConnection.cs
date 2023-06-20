using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHM
{
    public partial class FormConnection : Form
    {
        private string server;
        private string database;
        private string username;
        private string password;

        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            ReadConfigFile();
        }

        private void ReadConfigFile()
        {
            string configFile = @"C:\ahm\AplikasiAHM\config.txt";

            if (File.Exists(configFile))
            {
                string[] lines = File.ReadAllLines(configFile);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (key)
                        {
                            case "Server":
                                server = value;
                                break;
                            case "Database":
                                database = value;
                                break;
                            case "Username":
                                username = value;
                                break;
                            case "Password":
                                password = value;
                                break;
                        }
                    }
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Buat string koneksi berdasarkan informasi yang telah diset
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};";

            // Coba melakukan koneksi ke SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");

                    FormConfiguration formConfiguration = new FormConfiguration(connectionString);
                    formConfiguration.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

    }
}