using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


//
//Spis tego, jaki obiekt odpowiada za pozycje menu
//tableLayoutPanel1   -   dodaj zlecenie
//tableLayoutPanel2   -   Weź zlecenie
//tableLayoutPanel3   -   Dodaj użytkownika
//tableLayoutPanel4   -   Usuń użytkownika
//tableLayoutPanel5   -   Przypisz zlecenie 
//datagridview1(tworzone podczas kliknięcia w pozycje menu)   -   zlecenia, moje zlecenia
//
//
//Form1 - strona główna aplikacji
//Form2 - okno Zaloguj się
//Form3 - okno Połączenie
//
//

namespace FixUpGuy
{
    public partial class Form1 : Form
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

        //********************************************************************
        //Zmienne wykorzystywane do wyświetlenia danych z bazy do DataGridView
        MySqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataSet uz = new DataSet();
        DataGridView datagridview1;

        string sql; //zmienna w której będą przechowywane zapytania do bazy 

        //********************************************************************
        //Zmienne wykorzystywane do sprawdzenia czy obiekt został utworzony
        bool czy_utworzono_DGV_zlecenia = false; //czy utworzono DataGridView dla zlecenia(false - nie utworzono, true - utworzono)
        bool czy_utworzono_DGV_moje_zlecenia = false; //czy utworzono DataGridView dla moje zlecenia(false - nie utworzono, true - utworzono)

        //
        //inne zmienne
        string typ_pracownika_zabezpieczenie;
        int id_uzytkownika;



        public Form1()
        {
            InitializeComponent();
   
            typ_pracownika_zabezpieczenie = Properties.Settings.Default.Typ_konta;

            //Ukrycie wszystkiego, a następnie pokazanie według typu konta
            ukryj_wszystko();
            interfejs_typu_konta(typ_pracownika_zabezpieczenie);

            tableLayoutPanel1.Visible = false;
            flowLayoutPanel3.Visible = false;

            //Properties.Settings.Default.Reset();

            //---------------------------------------------------------------------
            //Przypisanie danych do zmiennych wykorzystywanych do połączenia z bazą
            /*
            server = "localhost";
            database = "fixupguy";
            user = "root";
            password = "";
            port = "3307";
            sslM = "none";
            */
            if (Properties.Settings.Default.Server == "empty")
            {
                ukryj_wszystko();
                połaczenieToolStripMenuItem.Visible = true;
            }
            else
            {
                server = Properties.Settings.Default.Server;
                database = Properties.Settings.Default.Database;
                user = Properties.Settings.Default.User;
                password = Properties.Settings.Default.Password;
                port = Properties.Settings.Default.Port;
                sslM = "none";
            }
            
            connectionString = String.Format("server={0}; port={1}; user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);



            
            
            
        }

        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        //****FUNKCJE***********FUNKCJE************FUNKCJE**********FUNKCJE************FUNKCJE*******FUKCJE**************FUNKCJE**************FUNKCJE******************
        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************

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

        //***********************************************************************************************************************************
        //Funkcja która pobiera zlecenia z bazy danych, tworzy DataGridView, a następnie wyświetla pobrane zlecenia w utworzonym DataGridView
        private void pokaz_dostepne_zlecenia(string pdz_sql)
        {
            //-----------------------------
            //Ukrycie zbędnych elementów UI
            tableLayoutPanel1.Visible = false;


            datagridview1 = new DataGridView(); //Stworzenie DataGridView

            try
            {
                conexion(); //otworzenie połączenia z bazą

                adapter = new MySqlDataAdapter(pdz_sql, connection);
                adapter.Fill(ds);

                datagridview1.AutoGenerateColumns = true;
                datagridview1.ColumnHeadersVisible = true;

                flowLayoutPanel2.Controls.Add(datagridview1); //Dodanie DataGridView do interfejsu

                datagridview1.Width = 800;
                datagridview1.Height = 400;

                datagridview1.DataSource = ds.Tables[0]; //Przypisanie danych z bazy do DataGridView

                ustaw_styl_columns_DataGridView("opis");

                datagridview1.Columns["opis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                ustaw_styl_columns_DataGridView("link");

                datagridview1.Columns["link"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                connection.Close(); //zamknięcie połączenia
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //****************************************************
        //Funkcja dzięki której zmienia się styl danej kolumny
        private void ustaw_styl_columns_DataGridView(string nazwa_kolumny)
        {
            DataGridViewCellStyle cell_style = new DataGridViewCellStyle();
            cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cell_style.Format = "C2";

            datagridview1.Columns[nazwa_kolumny].DefaultCellStyle = cell_style;
        }

        //************************************************************************************
        //Funkcja sprawdzająca czy jest utworzony DGV dla zlecenia, jak jest to usuwa z ekranu
        private void czy_usunac_DGV()
        {
            if (czy_utworzono_DGV_zlecenia == true || czy_utworzono_DGV_moje_zlecenia == true)
            {
                flowLayoutPanel2.Controls.Remove(datagridview1); //usunięcie z ekranu datagridview1
                datagridview1.DataSource = null; //ustawienie data source na null
                datagridview1.Rows.Clear(); //usunięcie wierszy
                ds.Clear(); //wyczyszczenie danych z tabeli
                uz.Clear(); //wyczyszczenie danych z tabeli
                czy_utworzono_DGV_zlecenia = false;
            }
        }

        //***************************************
        //Ukrycie wszystkich elementów z menu
        private void ukryj_wszystko()
        {
            zleceniaToolStripMenuItem.Visible = false;
            wszystkieZleceniaToolStripMenuItem.Visible = false;
            mojeZleceniaToolStripMenuItem1.Visible = false;
            weźZlecenieToolStripMenuItem1.Visible = false;
            dodajZlecenieToolStripMenuItem1.Visible = false;
            przypiszZlecenieToolStripMenuItem.Visible = false;
            listaUżytkownikówToolStripMenuItem.Visible = false;

            użytkownikToolStripMenuItem.Visible = false;
            zalogujSięToolStripMenuItem1.Visible = false;
            dodajUżytkownikaToolStripMenuItem1.Visible = false;
            usuńUżytkownikaToolStripMenuItem1.Visible = false;
            wylogujSięToolStripMenuItem.Visible = false;

            połaczenieToolStripMenuItem.Visible = false;
        }

        //******************************************************
        //Funkcja ukrywająca elementy menu dla danego typu_konta
        private void interfejs_typu_konta(string typ_konta)
        {
            if(typ_konta == "administrator")
            {
                połaczenieToolStripMenuItem.Visible = false;

                użytkownikToolStripMenuItem.Visible = true;
                wylogujSięToolStripMenuItem.Visible = true;
                dodajUżytkownikaToolStripMenuItem1.Visible = true;
                usuńUżytkownikaToolStripMenuItem1.Visible = true;
                zalogujSięToolStripMenuItem1.Visible = false;
                przypiszZlecenieToolStripMenuItem.Visible = true;

                zleceniaToolStripMenuItem.Visible = true;
                wszystkieZleceniaToolStripMenuItem.Visible = true;
                dodajZlecenieToolStripMenuItem1.Visible = true;
                listaUżytkownikówToolStripMenuItem.Visible = true;
            }
            else if(typ_konta == "serwisant")
            {
                połaczenieToolStripMenuItem.Visible = false;

                użytkownikToolStripMenuItem.Visible = true;
                wylogujSięToolStripMenuItem.Visible = true;
                zalogujSięToolStripMenuItem1.Visible = false;

                zleceniaToolStripMenuItem.Visible = true;
                wszystkieZleceniaToolStripMenuItem.Visible = true;
                mojeZleceniaToolStripMenuItem1.Visible = true;
                weźZlecenieToolStripMenuItem1.Visible = true;
            }
            else
            {
                użytkownikToolStripMenuItem.Visible = true;
                zalogujSięToolStripMenuItem1.Visible = true;
                połaczenieToolStripMenuItem.Visible = true;
            }
        }

        //
        //
        private void aktualizacja_wys_UI()
        {
            typ_pracownika_zabezpieczenie = Properties.Settings.Default.Typ_konta;
            interfejs_typu_konta(typ_pracownika_zabezpieczenie);
        }

        //**************************************************
        //Pobieranie ilości wierszy, aby ustalić ostatnie id
        private int pobierz_count(string sql)
        {
            int id_count;
            

            MySqlCommand cmd_count = new MySqlCommand(sql, connection);

            conexion();
            id_count = int.Parse(cmd_count.ExecuteScalar().ToString());
            connection.Close();


            id_count++;
            return id_count;
        }

        //***************************************************
        //Funkcja sprawdzająca, czy dane zlecenie jest zajęte
        private bool czy_dostepne(int id)
        {
            int wartosc_id_uz;
            sql = "SELECT id_uz FROM zlecenia WHERE id='" + id + "';";

            MySqlCommand cmd_czy_dostepne = new MySqlCommand(sql, connection);

            conexion();
            wartosc_id_uz = int.Parse(cmd_czy_dostepne.ExecuteScalar().ToString());
            connection.Close();

            if(wartosc_id_uz == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //***********************************************
        //Funkcja która wyświetla wszystkich użytkowników
        private void pokaz_uzytkownikow()
        {
            sql = "SELECT * FROM uzytkownicy";

            //-----------------------------
            //Ukrycie zbędnych elementów UI
            tableLayoutPanel1.Visible = false;


            datagridview1 = new DataGridView(); //Stworzenie DataGridView

            try
            {
                conexion(); //otworzenie połączenia z bazą

                adapter = new MySqlDataAdapter(sql, connection);
                adapter.Fill(uz);

                datagridview1.AutoGenerateColumns = true;
                datagridview1.ColumnHeadersVisible = true;

                flowLayoutPanel2.Controls.Add(datagridview1); //Dodanie DataGridView do interfejsu

                datagridview1.Width = 800;
                datagridview1.Height = 400;

                datagridview1.DataSource = uz.Tables[0]; //Przypisanie danych z bazy do DataGridView

                //ustaw_styl_columns_DataGridView("opis");

                //datagridview1.Columns["opis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                connection.Close(); //zamknięcie połączenia
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        //*******************************Elementy UI które są na ekranie (np.: przyciski, textboxy, tablelayoutpanel, itd...)******************************************
        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************

        //______________________________________________________________________________________________________________________________________
        //Przyciski z menu
        //______________________________________________________________________________________________________________________________________

        

        //Przycisk z menu "Wszystkie zlecenia"
        private void wszystkieZleceniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = false;

            if (typ_pracownika_zabezpieczenie == "administrator")
            {
                sql = "SELECT * FROM zlecenia"; //Co ma pokazac w zleceniach(w DataGridView)
            }
            if(typ_pracownika_zabezpieczenie == "serwisant")
            {
                sql = "SELECT id, data_dodania, termin, opis, kwota FROM zlecenia WHERE id_uz='0'";
            }
            czy_usunac_DGV();

            if (czy_utworzono_DGV_zlecenia == false)
            {

                pokaz_dostepne_zlecenia(sql); //Wywołanie funkcji która pokazuje dostępne zlecenia
                czy_utworzono_DGV_zlecenia = true;
            }
            else
            {
                //tutaj można wrzucić, żeby się aktualizowały dane
                czy_usunac_DGV();
                pokaz_dostepne_zlecenia(sql);
            }
        }

        
        //*******************************
        //Przycisk z menu "Moje zlecenia"
        private void mojeZleceniaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            flowLayoutPanel3.Visible = false;
            tableLayoutPanel1.Visible = false;

            id_uzytkownika = Properties.Settings.Default.id_uzytkownika;

            sql = "SELECT * FROM zlecenia WHERE id_uz='" + id_uzytkownika + "';";

            czy_usunac_DGV();

            if (czy_utworzono_DGV_moje_zlecenia == false)
            {
                pokaz_dostepne_zlecenia(sql);
                czy_utworzono_DGV_moje_zlecenia = true;
            }
            else
            {
                czy_usunac_DGV();
                pokaz_dostepne_zlecenia(sql);
            }
        }

        //******************************
        //Przycisk z menu "Weź zlecenie"
        private void weźZlecenieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            czy_usunac_DGV(); //usunięcie datagridview(zlecenia|moje zlecenia) z ekranu

            //--------------------------------------
            //Ukrycie/pokazanie elementów na ekranie
            flowLayoutPanel3.Visible = true;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = true;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;

            //----------------------------------------------------
            //Ustawienie rozmiaru elementów w oknie "Weź zlecenie"

            //Kontener na obiekty (tableLayoutPanel2)
            tableLayoutPanel2.Width = 800;
            tableLayoutPanel2.Height = 400;

            //TextBox ID
            text_wez_id.Width = 320;
            text_wez_id.Height = 20;

            //RichTextBox Komentarz
            richText_wez_kom.Width = 320;
            richText_wez_kom.Height = 200;

            //Przycisk po wciśnięciu którego bierzemy zlecenie (przycisk "weź zlecenie")
            but_wez_zlecenie.Width = 100;
            but_wez_zlecenie.Height = 50;
        }

        //********************************
        //Przycisk z menu "Dodaj zlecenie"
        private void dodajZlecenieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            czy_usunac_DGV(); //usunięcie datagridview(zlecenia|moje zlecenia) z ekranu

            //--------------------------------------
            //Ukrycie/pokazanie elementów na ekranie
            flowLayoutPanel3.Visible = true;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;

            //------------------------------------------------------
            //Ustawienie rozmiaru elementów w oknie "dodaj zlecenie"

            //Kontener na obiekty (tablelayoutpanel1)
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.Width = 800;
            tableLayoutPanel1.Height = 400;

            //RichTextBox opis
            text_opis.Width = 379;
            text_opis.Height = 217;

            //Kalendarz
            monthCalendar1.Width = 269;
            monthCalendar1.Height = 162;

            //TextBox link
            text_link.Width = 379;
            text_link.Height = 20;

            //Przycisk dodający zlecenie
            but_dodaj.Width = 104;
            but_dodaj.Height = 42;
        }

        //*****************************
        //Przycisk z menu "Zaloguj się"
        private void zalogujSięToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 zaloguj_sie = new Form2();
            zaloguj_sie.FormClosed += zaloguj_sie_FormClosed;
            zaloguj_sie.Show();
        }

        //***********************************
        //Przycisk z menu "Dodaj użytkownika"
        private void dodajUżytkownikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            czy_usunac_DGV(); //usunięcie datagridview(zlecenia|moje zlecenia) z ekranu

            //--------------------------------------
            //Ukrycie/pokazanie elementów na ekranie
            flowLayoutPanel3.Visible = true;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel3.Visible = true;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;

            //------------------------------------------------------
            //Ustawienie rozmiaru elementów w oknie "dodaj zlecenie"

            //Kontener na obiekty (tableLayoutPanel3)
            tableLayoutPanel3.Width = 800;
            tableLayoutPanel3.Height = 400;

            //textBox login
            textBox_dodajuz_login.Width = 150;
            textBox_dodajuz_login.Height = 20;

            //textBox hasło
            textBox_dodajuz_haslo.Width = 150;
            textBox_dodajuz_haslo.Height = 20;

            //textBox email
            textBox_dodajuz_email.Width = 150;
            textBox_dodajuz_email.Height = 20;

            //flowLayoutPanel dla radiobutton
            flowLayoutPanel_dodajuz_radio.Width = 353;
            flowLayoutPanel_dodajuz_radio.Height = 53;

            //Przycisk dodający uzytkownika
            button_dodajuz_dodaj.Width = 80;
            button_dodajuz_dodaj.Height = 40;
        }

        //**********************************
        //Przycisk z menu "usuń użytkownika"
        private void usuńUżytkownikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            czy_usunac_DGV(); //usunięcie datagridview(zlecenia|moje zlecenia) z ekranu

            //--------------------------------------
            //Ukrycie/pokazanie elementów na ekranie
            flowLayoutPanel3.Visible = true;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel5.Visible = false;

            //------------------------------------------------------
            //Ustawienie rozmiaru elementów w oknie "dodaj zlecenie"

            //Kontener na obiekty (tableLayoutPanel4)
            tableLayoutPanel4.Width = 800;
            tableLayoutPanel4.Height = 400;

            //textbox podaj login
            textBox_usunuz_login.Width = 100;
            textBox_usunuz_login.Height = 20;

            //button usuń użytkownika
            button_usunuz_usun.Width = 75;
            button_usunuz_usun.Height = 25;
        }

        //********************
        //Przycisk z menu "Wyloguj się"
        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset(); //reset wszystkich zapisanych danych
            this.Close(); //zamknięcie aplikacji
        }

        //****************************
        //Przycisk z menu "Połączenie"
        private void połaczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 polacz = new Form3();
            polacz.FormClosed += polacz_FormClosed;
            polacz.Show();
        }

        //***********************************
        //Przycisk z menu "Przypisz zlecenie"
        private void przypiszZlecenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_usunac_DGV(); //usunięcie datagridview(zlecenia|moje zlecenia) z ekranu

            //--------------------------------------
            //Ukrycie/pokazanie elementów na ekranie
            flowLayoutPanel3.Visible = true;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = true;

            //------------------------------------------------------
            //Ustawienie rozmiaru elementów w oknie "dodaj zlecenie"

            //Kontener na obiekty (tableLayoutPanel5)
            tableLayoutPanel5.Width = 800;
            tableLayoutPanel5.Height = 400;

            //textBox id zlecenia
            textBox_przyp_id_zlec.Width = 50;
            textBox_przyp_id_zlec.Height = 20;

            //textBox id klienta
            textBox_przyp_id_klient.Width = 50;
            textBox_przyp_id_klient.Height = 20;

            //Przycisk Przypisujący zlecenie
            button_przypisz_zlecenie.Height = 50;
            button_przypisz_zlecenie.Width = 75;

        }

        //************************************
        //Przycisk z menu "Lista użytkowników"
        private void listaUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = false;
            tableLayoutPanel1.Visible = false;

            //id_uzytkownika = Properties.Settings.Default.id_uzytkownika;

            //sql = "SELECT * FROM zlecenia WHERE id_uz='" + id_uzytkownika + "';";

            czy_usunac_DGV();

            if (czy_utworzono_DGV_moje_zlecenia == false)
            {
                pokaz_uzytkownikow();
                czy_utworzono_DGV_moje_zlecenia = true;
            }
            else
            {
                czy_usunac_DGV();
                pokaz_uzytkownikow();
            }
        }

        //_________________________________________________________________________________________________________________________________________________
        //Inne elementy(przyciski, textboxy i  inne takie)
        //_________________________________________________________________________________________________________________________________________________

        //Wykonuje się po zamknięciu okna logowania
        void zaloguj_sie_FormClosed(object sender, FormClosedEventArgs e)
        {
            aktualizacja_wys_UI();
        }

        //Wykonuje się po zamknięciu okna połączenia
        void polacz_FormClosed(object sender, FormClosedEventArgs e)
        {
            server = Properties.Settings.Default.Server;
            database = Properties.Settings.Default.Database;
            user = Properties.Settings.Default.User;
            password = Properties.Settings.Default.Password;
            port = Properties.Settings.Default.Port;
            sslM = "none";

            connectionString = String.Format("server={0}; port={1}; user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

            aktualizacja_wys_UI();
        }


        //**************************
        //Przycisk dodający zlecenie
        private void but_dodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime aktualna_data = DateTime.Today;
                string aktualna_data_string = aktualna_data.ToString("yyyy-MM-dd");
                //DateTime now = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                sql = "SELECT COUNT(id) FROM zlecenia";
                int count_zlecenia;
                count_zlecenia = pobierz_count(sql);
                string termin = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                sql = "INSERT INTO `zlecenia`(`id`, `id_uz`, `data_dodania`, `termin`, `opis`, `kwota`, `link`) VALUES ('" + count_zlecenia + "', '0', '" + aktualna_data_string + "', '" + termin + "', '" + text_opis.Text + "', '0', '" + text_link.Text + "')";


                zlecenia zlecenie = new zlecenia(count_zlecenia, termin, termin, text_opis.Text, 0, text_link.Text);

                MySqlCommand cmd_dodaj_zlecenie = new MySqlCommand(sql, connection);

                MySqlDataReader reader_dodaj_zlecenie;
                conexion();
                reader_dodaj_zlecenie = cmd_dodaj_zlecenie.ExecuteReader();
                while (reader_dodaj_zlecenie.Read())
                {

                }
                connection.Close();
                MessageBox.Show("Dodano zlecenie!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        //**************************
        //Przycisk Dodaj użytkownika
        private void button_dodajuz_dodaj_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(id) FROM uzytkownicy";

            int count_uzytkownicy;
            count_uzytkownicy = pobierz_count(sql);

            string dodaj_login = textBox_dodajuz_login.Text;
            string dodaj_haslo = textBox_dodajuz_haslo.Text;
            string dodaj_mail = textBox_dodajuz_email.Text;
            string dodaj_typkonta = "";

            if (radioButton_dodajuz_typadmin.Checked)
            {
                dodaj_typkonta = "administrator";
            }

            if (radioButton_dodajuz_typserwis.Checked)
            {
                dodaj_typkonta = "serwisant";
            }

            string query_dodaj_uz = "INSERT INTO uzytkownicy" + "(id, login, haslo, email, typ_konta) " + "VALUES (@id, @login, @haslo, @email, @typ_konta) ";

            conexion();
            MySqlCommand cmd_insert = new MySqlCommand(query_dodaj_uz, connection);

            if(dodaj_login != "" && dodaj_haslo != "" && dodaj_mail != "" && dodaj_typkonta != "")
            {
                cmd_insert.Parameters.Add("@id", MySqlDbType.Int32).Value = count_uzytkownicy;
                cmd_insert.Parameters.Add("@login", MySqlDbType.String).Value = dodaj_login;
                cmd_insert.Parameters.Add("@haslo", MySqlDbType.String).Value = dodaj_haslo;
                cmd_insert.Parameters.Add("@email", MySqlDbType.String).Value = dodaj_mail;
                cmd_insert.Parameters.Add("@typ_konta", MySqlDbType.String).Value = dodaj_typkonta;

                cmd_insert.ExecuteNonQuery();

             
            }
            else
            {
                MessageBox.Show("Proszę wypełnij wszystkie pola");
            }

            connection.Close();
            MessageBox.Show("Dodano użytkownika!");
        }

        //******************************
        //Przycisk usuwający użytkownika
        private void button_usunuz_usun_Click(object sender, EventArgs e)
        {
            try
            {
                string query_delete_uz = "DELETE FROM uzytkownicy WHERE  login='" + textBox_usunuz_login.Text + "';";
                MySqlCommand cmd_delete = new MySqlCommand(query_delete_uz, connection);
                MySqlDataReader Delete_reader;

                conexion();

                Delete_reader = cmd_delete.ExecuteReader();
                MessageBox.Show("Usunięto użytkownika o loginie: " + textBox_usunuz_login.Text);

                while (Delete_reader.Read())
                {

                }

                connection.Close();

                textBox_usunuz_login.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //****************
        //Kalendarz
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //********************************
        //Przycisk który "bierze zlecenie"
        private void but_wez_zlecenie_Click(object sender, EventArgs e)
        {
            try
            {
                bool czy_dostepne = this.czy_dostepne(int.Parse(text_wez_id.Text)); //przypisanie wartości która zwraca funkcja do zmiennej 

                //Jeśli funkcja zwraca wartość true, to znaczy, że zlecenie jest dostępne
                if (czy_dostepne == true)
                {
                    id_uzytkownika = Properties.Settings.Default.id_uzytkownika; //przypisanie zmiennej id użytkownika

                    //MessageBox.Show(id_uzytkownika.ToString());

                    sql = "UPDATE zlecenia SET id_uz='" + id_uzytkownika + "' WHERE id='" + text_wez_id.Text + "';"; //Zapytanie sql które przypisuje użytkownika do zlecenia

                    MySqlCommand cmd_update = new MySqlCommand(sql, connection);
                    MySqlDataReader reader_update;

                    conexion();
                    reader_update = cmd_update.ExecuteReader();

                    while (reader_update.Read())
                    {

                    }

                    connection.Close();

                    MessageBox.Show("Wziąłeś zlecenie o ID = " + text_wez_id.Text);
                }
                else
                {
                    MessageBox.Show("To zlecenie jest już zajęte!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //******************************
        //Przycisk przypisujący zlecenie
        private void button_przypisz_zlecenie_Click(object sender, EventArgs e)
        {
            try
            {
                bool czy_dostepne = this.czy_dostepne(int.Parse(textBox_przyp_id_zlec.Text)); //przypisanie wartości która zwraca funkcja do zmiennej 

                //Jeśli funkcja zwraca wartość true, to znaczy, że zlecenie jest dostępne
                if (czy_dostepne == true)
                {
                    sql = "UPDATE zlecenia SET id_uz='" + textBox_przyp_id_klient.Text + "' WHERE id='" + textBox_przyp_id_zlec.Text + "';"; //Zapytanie sql które przypisuje użytkownika do zlecenia

                    MySqlCommand cmd_update = new MySqlCommand(sql, connection);
                    MySqlDataReader reader_update;

                    conexion();
                    reader_update = cmd_update.ExecuteReader();

                    while (reader_update.Read())
                    {

                    }

                    connection.Close();

                    MessageBox.Show("Udało się!");
                }
                else
                {
                    MessageBox.Show("To zlecenie jest już zajęte!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //***********************************
        //TextBox "Hasło" w dodaj użytkownika
        private void textBox_dodajuz_haslo_TextChanged(object sender, EventArgs e)
        {
            textBox_dodajuz_haslo.PasswordChar = '*';
        }

        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        //*******************************Puste/niepotrzebne elementy UI************************************************************************************************
        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //
        //tableLayoutPanel jest kontenerem dla elementów wyświetlanych po wciśnięciu przycisku "weź zlecenie"
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //
        //tableLayoutPanel jest kontenerem dla elementów wyświetlanych po wciśnięciu przycisku "Weź zlecenie"
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        //**************************
        //Przycisk z menu "Zlecenia"
        private void zleceniaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }


        //*****************************
        //Przycisk menu "Moje zlecenia"
        private void mojeZleceniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //****************************
        //Przycisk menu "Weź zlecenie"
        private void weźZlecenieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //********************************
        //Przycisk z menu "Dodaj zlecenie"
        private void dodajZlecenieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //*****************************
        //Przycisk z menu "Zaloguj się"
        private void zalogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //***********************************
        //Przycisk z menu "Dodaj użytkownika"
        private void dodajUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //**********************************
        //Przycisk z menu "Usuń użytkownika"
        private void usuńUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //kontener na UI przypisz zlecenie
        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        



        //*************************************************************************************************************************************************************
        //*************************************************************************************************************************************************************







    }
}
