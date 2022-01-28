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
    public partial class Form2 : Form
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

        private string sql;

        //private string login;
        //private string haslo;
        //private string typ_konta;

        private bool zabezpieczenie_odczyt_loghasla = false;

        public Form2()
        {
            InitializeComponent();

            //---------------------------------------------------------------------
            //Przypisanie danych do zmiennych wykorzystywanych do połączenia z bazą
            server = Properties.Settings.Default.Server;
            database = Properties.Settings.Default.Database;
            user = Properties.Settings.Default.User;
            password = Properties.Settings.Default.Password;
            port = Properties.Settings.Default.Port;
            sslM = "none";

            connectionString = String.Format("server={0}; port={1}; user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

            text_form2_password.PasswordChar = '*';
        }

        //*************************************
        //Otworzenie połączenia z bazą
        private void conexion()
        {
            try
            {
                connection.Open();

                //MessageBox.Show("successful connection");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }

        //****************************
        //Pobranie liczby użytkowników
        private int liczba_uzytkownikow()
        {
            sql = "SELECT COUNT(*) FROM uzytkownicy";
            MySqlCommand cmd_count = new MySqlCommand(sql, connection);
            conexion();
            int count_uzyt = int.Parse(cmd_count.ExecuteScalar().ToString());
            connection.Close();
            return count_uzyt;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //**************************************************************************
        //Przycisk zaloguj się, który sprawdza czy podane dane logowania są poprawne
        private void but_form2_zaloguj_Click(object sender, EventArgs e)
        {
            string[] tabela_login = new string[liczba_uzytkownikow()]; //tabela do przechowywania wszystkich loginów z bazy
            string[] tabela_haslo = new string[liczba_uzytkownikow()]; //tabela do przechowywania wszystkich haseł z bazy

            sql = "SELECT * FROM uzytkownicy"; //weź wszystko z tabeli uzytkownicy

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            conexion();
            MySqlDataReader rdr = cmd.ExecuteReader();
            

            uzytkownik user = new uzytkownik(0, text_form2_login.Text, text_form2_password.Text, "empty"); //utworzenie instancji użytkownika

            //w pętli while pobiorą się wszystkie loginy i hasla z bazy
            while (rdr.Read())
            {
                int pobierz_id = rdr.GetInt32(0);
                string pobierz_login = rdr.GetString(1);
                string pobierz_haslo = rdr.GetString(2);

                tabela_login[pobierz_id - 1] = pobierz_login;
                tabela_haslo[pobierz_id - 1] = pobierz_haslo;

            }
            connection.Close();

            //
            //W pętli for sprawdzi wszystkie pobrane loginy i hasła, jeśli te wpisane będą się zgadzać, z tymi z bazy, to zaloguje
            for (int i = 0; i <= tabela_login.Length - 1; i++)
            {
                if (user.Login == tabela_login[i] && user.Haslo == tabela_haslo[i])
                {
                    //Wyciąganie id użytkownika z bazy danych
                    string sql_id_uzytkownika = "SELECT id FROM uzytkownicy WHERE login = @login";
                    MySqlCommand cmd_id_uz = new MySqlCommand(sql_id_uzytkownika, connection);
                    cmd_id_uz.Parameters.Add("@login", MySqlDbType.String);
                    cmd_id_uz.Parameters["@login"].Value = tabela_login[i];

                    //Wyciąganie typu konta z bazy danych
                    sql = "SELECT typ_konta FROM uzytkownicy WHERE login = @login";
                    MySqlCommand cmd2 = new MySqlCommand(sql, connection);
                    cmd2.Parameters.Add("@login", MySqlDbType.String);
                    cmd2.Parameters["@login"].Value = tabela_login[i];

                    conexion();
                    user.Typ_konta = cmd2.ExecuteScalar().ToString();
                    user.Id_uz = int.Parse(cmd_id_uz.ExecuteScalar().ToString());
                    connection.Close();

                    Properties.Settings.Default.Login = tabela_login[i];
                    Properties.Settings.Default.Haslo = tabela_haslo[i];
                    Properties.Settings.Default.Typ_konta = user.Typ_konta;
                    Properties.Settings.Default.id_uzytkownika = user.Id_uz;

                    Properties.Settings.Default.Save();

                    Form1 form1 = new Form1();

                    zabezpieczenie_odczyt_loghasla = true;
                    MessageBox.Show("Udało się!");
                    this.Close();
                 
                } 
            }
            if (zabezpieczenie_odczyt_loghasla == false)
            {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        private void text_form2_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void text_form2_password_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
