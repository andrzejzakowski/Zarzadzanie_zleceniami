using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FixUpGuy
{
    public partial class Form3 : Form
    {

        //*******************************************
        //Zmienne wykorzystywane do połączenia z bazą

        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;


        public Form3()
        {
            InitializeComponent();
        }

        private void button_polaczenie_polacz_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------------------
            //Przypisanie danych do zmiennych wykorzystywanych do połączenia z bazą
            server = textBox_polaczenie_server.Text;
            database = textBox_polaczenie_database.Text;
            user = textBox_polaczenie_login.Text;
            password = textBox_polaczenie_haslo.Text;
            port = textBox_polaczenie_port.Text;
            sslM = "none";

            connectionString = String.Format("server={0}; port={1}; user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

            conexion();
        }

        //*************************************
        //Otworzenie połączenia z bazą
        private void conexion()
        {
            try
            {
                connection.Open();

                MessageBox.Show("successful connection");

                Properties.Settings.Default.Server = server;
                Properties.Settings.Default.Database = database;
                Properties.Settings.Default.User = user;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Port = port;

                Properties.Settings.Default.Save();

                connection.Close();

                this.Close();

            }
            catch (MySqlException ex)
            {
                Properties.Settings.Default.Server = "empty";

                Properties.Settings.Default.Save();
                MessageBox.Show(ex.Message + connectionString);
            }
        }
    }
}
